using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chmury
{
    public sealed class Cloud
    {
        private List<CloudData> cloudData;
        private static Cloud _instance;
        private List<string> listOfCloudCategory;
        private Dictionary<string, double> listOfAVGPrecipitationForCloudCategory;

        public string Value { get; set; }

        private static readonly object _lock = new object();
        public static Cloud GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Cloud();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }
            private Cloud()
        {
            cloudData = new List<CloudData>();
            initalizeData();
            initalizeCloudCategoryList();
        }
        private void initalizeData()
        {
            using (var reader = new StreamReader(@"C:\Users\programista\Desktop\4a\Kesoyu\c#\Chmury\Chmury\Chmury\pogoda.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    int.TryParse(values[0], out int d);
                    float.TryParse(values[1], out float t);
                    int.TryParse(values[2], out int p);
                    int.TryParse(values[4], out int s);
                    cloudData.Add(new CloudData(d, t, p, values[3],s));
                }
            }
        }

        private void initalizeCloudCategoryList()
        {
            listOfCloudCategory = new List<string>();
            for(int i = 1; i < 6; i++)
            {
                listOfCloudCategory.Add("C" + i);
                listOfCloudCategory.Add("S" + i);
            }
        }

        public Dictionary<int, int> simulationAccordingToTheory() {
            Dictionary<int,int> results = new Dictionary<int, int>();
            int counter = 0;
            int cloudSize = 0;
            for(int i = 0; i < 6; i++)
            {
                results.Add(i, 0);
            }
            results[0]++;
            for(int i=1; i < 500;i++)
            {
                if (counter == 3)
                {
                    cloudSize++;
                    if (cloudSize == 6)
                    {
                        cloudSize = 0;
                    }
                    counter = 0;
                }

                if (cloudSize == 0)    
                {
                    results[0]++;
                    counter = 0;
                    cloudSize++;
                }
                else
                {
                    results[cloudSize]++;
                    counter++;
                    Console.WriteLine("" + cloudSize + ", " + counter);
                    if (cloudData[i].precipitation >= 20 && cloudSize==5)
                    {
                        counter= 0;
                        cloudSize = 0;
                    }
                }
            }

            return results;
        }

        public Dictionary<string, double> calcAVGPrecipitationForCloudCategory()
        {
            listOfAVGPrecipitationForCloudCategory = new Dictionary<string, double>();
            List<CloudPrecipitationAndCategory> keyValuePairs = new List<CloudPrecipitationAndCategory>();
            for(int i=0; i < cloudData.Count;i++) {
                keyValuePairs.Add(new CloudPrecipitationAndCategory(cloudData[i].category+""+ cloudData[i].size, cloudData[i].precipitation));
            }
            for(int i=0;i < listOfCloudCategory.Count; i++)
            {
                listOfAVGPrecipitationForCloudCategory.Add(listOfCloudCategory[i], Math.Round(keyValuePairs.Where(x => x.category == listOfCloudCategory[i]).Average(x=>x.value),2,MidpointRounding.ToEven));
            }
            return listOfAVGPrecipitationForCloudCategory;
        }

        public void showAllData()
        {
            for(int i =0;i<cloudData.Count;i++)
                Console.WriteLine(cloudData[i].day+": " + cloudData[i].temperature+", " + cloudData[i].precipitation+", " + cloudData[i].category+", " + cloudData[i].size);
        }

        public void showlistOfCloudCategory()
        {
            for (int i = 0; i < listOfCloudCategory.Count; i++)
                Console.WriteLine(listOfCloudCategory[i]);
        }

        public int firstExSelectedDays()
        {
            int daysCounter = 0;
            for(int i = 0; i < cloudData.Count; i++)
                if (cloudData[i].temperature>=20 && cloudData[i].precipitation <= 5)
                    daysCounter++;
            return daysCounter;
        }
        public List<int> secondExSelectedDays() {
            List<int> finalResult= new List<int>();
            int counter = 0;
            int xddcounter = 0;
            int firstDay = 0;
            int lastDay = 0;
            for(int i = 1; i < cloudData.Count; i++)
            {
                if (cloudData[i].temperature > cloudData[i - 1].temperature)
                {
                    if (finalResult.Count == 0)
                    {
                        finalResult.Add(i-1);
                        finalResult.Add(i);
                        xddcounter++;
                    }
                    counter++;
                    if (firstDay == finalResult[0])
                    {
                        finalResult[1] = i;
                        xddcounter++;
                    }
                        
                }
                else
                {
                    if (finalResult.Count != 0)
                    {
                        if (counter > xddcounter)
                        {
                            xddcounter = counter;
                            finalResult[0] = firstDay;
                            finalResult[1] = i;
                        }
                        firstDay = i+1;
                        counter = 0;
                    }
                }
                
            }

            return finalResult;
        }
    }

    
}
