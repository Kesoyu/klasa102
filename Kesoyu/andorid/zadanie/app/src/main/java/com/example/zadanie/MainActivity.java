package com.example.zadanie;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }


    public void define() {
        int i = 1;
        Button like = (Button) findViewById(R.id.like);
                like.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        i++;

                    }
                });
        Button save = (Button) findViewById(R.id.save);
        Button del = (Button) findViewById(R.id.del);
        TextView desc = (TextView) findViewById(R.id.desc);
        TextView counter = (TextView) findViewById(R.id.likeCounter);

    }





