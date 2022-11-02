package com.example.cos;

import java.util.ArrayList;

public class Pytanie {
    private int tresc;
    private int idobrazka;
    private ArrayList<Integer> odpowiedzi;
    private int podpowiedz;
    private int odpowiedz;
    public static ArrayList<Pytanie> pytaniaArrayList;

    public static void przygotujPytania() {
        pytaniaArrayList = new ArrayList<>();
        pytaniaArrayList.add(new Pytanie(R.string.pytanie_szczyt, R.drawable.szczyt_1,  R.string.opis,0, R.string.odp_a, R.string.odp_b, R.string.odp_c));
        //pytaniaArrayList.add(new Pytanie(R.string.pytanie_szczyt, R.drawable.szczyt_1, 1, R.string.opis, R.string.odp_a, R.string.odp_b, R.string.odp_c));
        pytaniaArrayList.add(new Pytanie(R.string.pytanie_kierowca,R.drawable.norris,R.string.opis2,1,R.string.odp_a2,R.string.odp_b2,R.string.odp_c2));
        pytaniaArrayList.add(new Pytanie(R.string.pytanie_bolid,R.drawable.mercedes_bolid_2022,R.string.opis3,1,R.string.odp_a3,R.string.odp_b3,R.string.odp_c3));
        pytaniaArrayList.add(new Pytanie(R.string.pytanie_szef,R.drawable.toto_wolff,R.string.opis4,0,R.string.odp_a4,R.string.odp_b4,R.string.odp_c4));
        //return pytaniaArrayList;
    }

    public Pytanie(int tresc, int idobrazka, int podpowiedz, int odpowiedz, int odpa, int odpb, int odpc) {
        this.tresc = tresc;
        this.idobrazka = idobrazka;
        this.podpowiedz = podpowiedz;
        this.odpowiedz = odpowiedz;
        this.odpowiedzi = new ArrayList<>();
        this.odpowiedzi.add(odpa);
        this.odpowiedzi.add(odpb);
        this.odpowiedzi.add(odpc);
    }

    public int getTresc() {
        return tresc;
    }

    public void setTresc(int tresc) {
        this.tresc = tresc;
    }

    public int getIdobrazka() {
        return this.idobrazka;
    }

    public void setIdobrazka(int idobrazka) {
        this.idobrazka = idobrazka;
    }

    public ArrayList<Integer> getOdpowiedzi() {
        return odpowiedzi;
    }

    public void setOdpowiedzi(ArrayList<Integer> odpowiedzi) {
        this.odpowiedzi = odpowiedzi;
    }

    public int getPodpowiedz() {
        return podpowiedz;
    }

    public void setPodpowiedz(int podpowiedz) {
        this.podpowiedz = podpowiedz;
    }

    public int getOdpowiedz() {
        return odpowiedz;
    }

    public void setOdpowiedz(int odpowiedz) {
        this.odpowiedz = odpowiedz;
    }
}
