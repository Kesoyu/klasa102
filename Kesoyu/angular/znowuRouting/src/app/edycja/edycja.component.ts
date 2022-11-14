import { Component, OnInit } from '@angular/core';
import { Samochod } from '../samochod';
import { SAMOCHODY } from '../samochody';

@Component({
  selector: 'app-edycja',
  templateUrl: './edycja.component.html',
  styleUrls: ['./edycja.component.css']
})
export class EdycjaComponent implements OnInit {

  constructor() { }
  autka:Samochod [] = SAMOCHODY; 
  ngOnInit(): void {
  }

}
