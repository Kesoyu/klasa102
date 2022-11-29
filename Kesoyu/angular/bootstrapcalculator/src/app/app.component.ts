import { Component } from '@angular/core';

const dictionary:{[key:string]:number} = {
  'nb':0.01, "1":1,"1+":1.5,"2-":1.75,"2":2,"2+":2.5,"3-":2.75,"3":3,"3+":3.5,"4-":3.75,"4":4,"4+":4.5,"5-":4.75,"5":5,"5+":5.5,"6-":5.75,"6":6
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})



export class AppComponent {
  title = 'bootstrapcalculator';
}
