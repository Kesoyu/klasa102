package com.example.listviewzadanko;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.IOException;
import java.io.OutputStreamWriter;
import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ListView listView;
    Button send;
    EditText itemn;
    EditText itemd;
    EditText types;
    ArrayList<String> itemList;
    Button send2;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        listView=findViewById(R.id.listview);
        send = findViewById(R.id.send);
        itemn = findViewById(R.id.name);
        itemd = findViewById(R.id.desc);
        types = findViewById(R.id.type);
        itemList = new ArrayList<>();
        send2 = findViewById(R.id.send2);



        String name = itemn.getText().toString();
        String desc = itemd.getText().toString();
        String type = types.getText().toString();

        ArrayAdapter<String> adapter = new ArrayAdapter(this, android.R.layout.simple_list_item_1,itemList);

        listView.setAdapter(adapter);
        send.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                String name = itemn.getText().toString();
                if (!name.isEmpty()) {

                    itemList.add(name);

                    adapter.notifyDataSetChanged();
                }
                 else {
                     Toast.makeText(MainActivity.this,"nie podales nazwy!", Toast.LENGTH_SHORT).show();
                }
            }
        });
           listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
               @Override
               public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                   Toast.makeText(MainActivity.this,"zapisano do JSON", Toast.LENGTH_SHORT).show();

                   String desc = itemd.getText().toString();
                   String type = types.getText().toString();
                   String name = itemn.getText().toString();

                   adapter.notifyDataSetChanged();

                   writeToFile();
               }


            });

       public void writeToFile(String data,Context context) {
            try {
                OutputStreamWriter outputStreamWriter = new OutputStreamWriter(context.openFileOutput("config.txt", Context.MODE_PRIVATE));
                outputStreamWriter.write(data);
                outputStreamWriter.close();
            }
            catch (IOException e) {
                Log.e("Exception", "File write failed: " + e.toString());
            }
        }



    }
}