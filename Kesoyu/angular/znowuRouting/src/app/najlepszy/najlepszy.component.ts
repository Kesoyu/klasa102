import { Component, OnInit } from '@angular/core';
import { Samochod } from '../samochod';
import { SAMOCHODY } from '../samochody';

@Component({
  selector: 'app-najlepszy',
  templateUrl: './najlepszy.component.html',
  styleUrls: ['./najlepszy.component.css']
})
export class NajlepszyComponent implements OnInit {

  constructor() { }

  auto!:Samochod; 
  ngOnInit(): void {
    this.auto = this.znajdzNajlepszy();
  }

  autka:Samochod[] = SAMOCHODY;

  znajdzNajlepszy():Samochod{
    let najlepszySamochod:Samochod = this.autka[0];
    let maks:number = 0;
    this.autka.forEach(auto => {
      if(maks < auto.ranking)
      { 
        maks = auto.ranking; 
        najlepszySamochod = auto;
      }
    });
    return najlepszySamochod;
  }
}