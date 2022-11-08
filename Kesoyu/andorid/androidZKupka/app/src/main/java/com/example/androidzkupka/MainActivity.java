package com.example.androidzkupka;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.Toast;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    EditText editText;
    Button btnNewWindow;
    Button button;
    ListView listaStatyczna;
    ListView drugaListaStatyczna;
    Spinner constSpiner;
    ArrayList<String> przedmioty = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        listaStatyczna = findViewById(R.id.listView);
        drugaListaStatyczna = findViewById(R.id.secondListView);
        editText = findViewById(R.id.editTextItemName);
        button = findViewById(R.id.btnAdd);
        constSpiner = findViewById(R.id.spinnerView);
        przedmioty.add("historia");
        przedmioty.add("język polski");
        przedmioty.add("wos");
        przedmioty.add("his");
        ArrayAdapter<String> adapterPrzedmioty = new ArrayAdapter<>(MainActivity.this, android.R.layout.simple_list_item_1, przedmioty);

        drugaListaStatyczna.setAdapter(adapterPrzedmioty);
        AdapterView.OnItemClickListener secondClicked = new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                przedmioty.remove(i);
                adapterPrzedmioty.notifyDataSetChanged();
            }
        };
        drugaListaStatyczna.setOnItemClickListener(secondClicked);

        AdapterView.OnItemSelectedListener selected = new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                String selectedItemText = adapterView.getItemAtPosition(i).toString();
                Toast.makeText(MainActivity.this, selectedItemText, Toast.LENGTH_LONG);
                Log.d("OnItemSelected", selectedItemText);
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        };
        AdapterView.OnItemClickListener clicked = new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                String clickedItemText = adapterView.getItemAtPosition(i).toString();
                Toast.makeText(MainActivity.this, clickedItemText, Toast.LENGTH_LONG);
                Log.d("OnItemClick", clickedItemText);
            }
        };
        listaStatyczna.setOnItemClickListener(clicked);
        constSpiner.setOnItemSelectedListener(selected);

        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                przedmioty.add(editText.getText().toString());
                adapterPrzedmioty.notifyDataSetChanged();
            }
        });
        btnNewWindow = findViewById(R.id.asd);
        btnNewWindow.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intencja = new Intent(MainActivity.this, MainActivity2.class);
                startActivity(intencja);
            }
        });
    }
}