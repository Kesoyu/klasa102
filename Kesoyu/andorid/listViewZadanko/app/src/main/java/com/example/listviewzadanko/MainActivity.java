package com.example.listviewzadanko;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
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

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ListView listView;
    Button send;
    EditText itemn;
    EditText itemd;
    EditText types;
    ArrayList<String> itemList;


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

       itemList.add("Usterka");
        String name = itemn.getText().toString();
        String desc = itemd.getText().toString();
        String type = types.getText().toString();

        ArrayAdapter<String> adapter = new ArrayAdapter(this, android.R.layout.simple_list_item_1,itemList);

        listView.setAdapter(adapter);
        send.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (!name.isEmpty()) {
                    String name = itemn.getText().toString();
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
                Toast.makeText(MainActivity.this,"wybrano usterke:"+i+" " +itemList.get(i).toString(),Toast.LENGTH_SHORT).show();
            }

        });
            listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
                @Override
                public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                    Intent intent = new Intent(MainActivity.this,listviewpomocna.class);
                    String desc = itemd.getText().toString();
                    String type = types.getText().toString();
                    String name = itemn.getText().toString();
                    intent.putExtra("desc", desc);
                    intent.putExtra("type", type);
                    intent.putExtra("name", name);
                    adapter.notifyDataSetChanged();
                    startActivity(intent);
                }
            });




    }
}