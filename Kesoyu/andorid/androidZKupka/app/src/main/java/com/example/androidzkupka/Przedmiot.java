package com.example.androidzkupka;

public class Przedmiot {
    private boolean zaznaczony;
    private String nazwa;

    public boolean isZaznaczony() {
        return zaznaczony;
    }

    public void setZaznaczony(boolean zaznaczony) {
        this.zaznaczony = zaznaczony;
    }

    public String getNazwa() {
        return nazwa;
    }

    public void setNazwa(String nazwa) {
        this.nazwa = nazwa;
    }
}
