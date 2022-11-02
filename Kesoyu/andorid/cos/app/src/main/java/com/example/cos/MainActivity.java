package com.example.cos;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.Checkable;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    Button checkButton;
    Button podpowiedzButton;
    RadioGroup odpowiedzRadioGroup;
    TextView pytanieTextView;
    RadioButton odpaRadioButton;
    RadioButton odpbRadioButton;
    RadioButton odpcRadioButton;
    ImageView imageView;
    ArrayList<Pytanie> pytanka;
    int kodPodpowiedzi = 0;
    int liczbaPunktow = 0;
    int aktualnyIndekx = 0;//będzie zerem, piszemy dla przejrzystości
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        pytanieTextView = findViewById(R.id.textViewPytanie);
        odpaRadioButton = findViewById(R.id.radioButton);
        odpbRadioButton = findViewById(R.id.radioButton2);
        odpcRadioButton = findViewById(R.id.radioButton3);
        Pytanie.przygotujPytania();
        pytanka = Pytanie.pytaniaArrayList;
        imageView = findViewById(R.id.imageView);
        wypelnijWidokiPytaniem(0);
        checkButton = findViewById(R.id.button);

        checkButton.setOnClickListener(
                new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
//                        if(check(pytanka.get(aktualnyIndekx).getOdpowiedz())){
//                            Toast.makeText(MainActivity.this,R.string.ok,Toast.LENGTH_SHORT).show();
                            //zlicznaie punktów
                        if(check(pytanka.get(aktualnyIndekx).getOdpowiedz())) {
                            liczbaPunktow++;
                            aktualnyIndekx++;
                            if (aktualnyIndekx == pytanka.size()) {
                                Toast.makeText(MainActivity.this,"Koniec testu zdobyłeś "+liczbaPunktow,Toast.LENGTH_SHORT).show();
                                aktualnyIndekx--;
                            }
                            wypelnijWidokiPytaniem(aktualnyIndekx);
                        }
                        //}
//                        else
//                        {
//                            Toast.makeText(MainActivity.this , R.string.nope,  Toast.LENGTH_SHORT ).show();
//                        }
                    }
                }
        );
        podpowiedzButton = findViewById(R.id.button2);
        podpowiedzButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intencja = new Intent(MainActivity.this, PodpowiedzActivity.class); //intencja jawna wiadomo skąd dokąd (xd)
                intencja.putExtra("Index",aktualnyIndekx);
                liczbaPunktow--;
                int requestCode = 0;
                startActivityForResult(intencja,requestCode);
            }
        });
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if(requestCode == RESULT_OK){
            //skorzystał z punktów
            liczbaPunktow--;
        }
    }

    private boolean check(int numerOdpowiedzi){
        RadioButton[] radioButtony =new RadioButton[]{odpaRadioButton, odpbRadioButton, odpcRadioButton};
        for(int i = 0 ; i< radioButtony.length; i++)
        {
            if(radioButtony[i].isChecked()) {
                if (i == numerOdpowiedzi) {
                    return true;
                } else {
                    return false;
                }
            }

        }
            return false;
    }
    void wypelnijWidokiPytaniem(int i){
        Pytanie aktyalnePytanie = pytanka.get(i);
        pytanieTextView.setText(aktyalnePytanie.getTresc());
        odpaRadioButton.setText(aktyalnePytanie.getOdpowiedzi().get(0));
        odpbRadioButton.setText(aktyalnePytanie.getOdpowiedzi().get(1));
        odpcRadioButton.setText(aktyalnePytanie.getOdpowiedzi().get(2));
        imageView.setImageResource(aktyalnePytanie.getIdobrazka());
        imageView.setContentDescription("Jakaś podpowiedź");//TODO poprawić
        odpaRadioButton.setChecked(false);
        odpbRadioButton.setChecked(false);
        odpcRadioButton.setChecked(false);
    }
}