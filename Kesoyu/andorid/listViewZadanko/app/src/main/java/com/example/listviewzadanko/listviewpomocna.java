package com.example.listviewzadanko;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class listviewpomocna extends AppCompatActivity {


    Button powr;
    TextView nazwa;
    TextView typ;
    TextView opis;
    Button zapis;





    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_listviewpomocna);



        nazwa = findViewById(R.id.itemname);
        opis = findViewById(R.id.itemdesc);
        typ = findViewById(R.id.itemtype);
        powr = findViewById(R.id.button);
        zapis = findViewById(R.id.datadow);

        Intent intent = getIntent();

       String nazw =  intent.getStringExtra("name");
       String typp = intent.getStringExtra("type");
       String opiss = intent.getStringExtra("desc");

        nazwa.setText(nazw);
        typ.setText(typp);
        opis.setText(opiss);



        powr.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(listviewpomocna.this, MainActivity.class));
            }
        });
    }
}