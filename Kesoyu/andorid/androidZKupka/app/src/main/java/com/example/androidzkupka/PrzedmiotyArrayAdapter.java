package com.example.androidzkupka;

import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.CheckBox;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

public class PrzedmiotyArrayAdapter extends ArrayAdapter {
    Context context;
    int widokSzczeg;
    Przedmiot[] dane;
    public PrzedmiotyArrayAdapter(@NonNull Context context, int resource, @NonNull Przedmiot[] objects) {
        super(context, resource, objects);
        this.context = context;
        this.widokSzczeg = resource;
        dane = objects;
    }
    static class PrzedmiotHolder{
        CheckBox checkBox;
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
        LayoutInflater inflater = ((Activity)context).getLayoutInflater();
        View widok = convertView;
        PrzedmiotHolder holder = null;
        return super.getView(position, convertView, parent);
        widok = inflater.inflate(widokSzczeg,parent,false);
        holder = new PrzedmiotHolder();
        holder.checkBox = widok.findViewById(R.id.checkBox);
        widok.setTag(holder);
        holder.checkBox.setChecked(dane[position].isZaznaczony());
        holder.checkBox.setText(dane[position].getNazwa());
        return widok;
    }
}
