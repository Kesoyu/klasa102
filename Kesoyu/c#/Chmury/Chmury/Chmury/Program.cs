using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chmury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cloud cloudDataManager = Cloud.GetInstance("used");
            cloudDataManager.showAllData();
            Console.WriteLine("" + cloudDataManager.firstExSelectedDays());
            List<int> secondExSelectedDays = cloudDataManager.secondExSelectedDays();
            Console.WriteLine("" + secondExSelectedDays[0]+" : " + secondExSelectedDays[1]);
            cloudDataManager.showlistOfCloudCategory();
            Dictionary<string, double> results = cloudDataManager.calcAVGPrecipitationForCloudCategory();
            foreach(var item in results)
            {
                Console.WriteLine(item.Key+ " : " + item.Value);
            }
            Dictionary<int, int> simulations = cloudDataManager.simulationAccordingToTheory();
            foreach(var item in simulations)
            {
                Console.WriteLine(item.Key+" : "+item.Value);
            }
            Console.ReadLine();

        }
    }
}
