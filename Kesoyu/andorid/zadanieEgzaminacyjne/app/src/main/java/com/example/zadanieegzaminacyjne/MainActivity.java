package com.example.zadanieegzaminacyjne;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListAdapter;
import android.widget.ListView;
import android.widget.TextView;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    TextView likeTextView;
    TextView titleTextView;
    ListView listViewSavedPlace;
    Button btnLike;
    Button btnDelete;
    Button btnSave;
    Button btnShowPlaced;
    ArrayList<String> savedPlace;
    int likeCounter = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        savedPlace = new ArrayList<String>();
        likeTextView = findViewById(R.id.textViewLikes);
        titleTextView = findViewById(R.id.textViewTitle);
        listViewSavedPlace = findViewById(R.id.listViewSavedPlace);
        btnLike = findViewById(R.id.btnLike);
        btnShowPlaced = findViewById(R.id.btnPlace);
        ArrayAdapter<String> adapterPlace = new ArrayAdapter<>(MainActivity.this, android.R.layout.simple_list_item_1, savedPlace);
        listViewSavedPlace.setAdapter(adapterPlace);
        btnLike.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                likeCounter++;
                updateLike(likeCounter);
            }
        });
        btnDelete = findViewById(R.id.btnDelete);
        btnDelete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(likeCounter > 0){
                    likeCounter--;
                    updateLike(likeCounter);
                }
            }
        });
        btnSave = findViewById(R.id.btnSave);
        btnSave.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                savedPlace.add(titleTextView.getText().toString());
                adapterPlace.notifyDataSetChanged();
            }
        });
        btnShowPlaced.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(listViewSavedPlace.getVisibility()==View.VISIBLE)
                    listViewSavedPlace.setVisibility(View.INVISIBLE);
                else
                    listViewSavedPlace.setVisibility(View.VISIBLE);
            }
        });
    }

    public void updateLike(int value){
        likeTextView.setText(value+" polubień");
    }
}