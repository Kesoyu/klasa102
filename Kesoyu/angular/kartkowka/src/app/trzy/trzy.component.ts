import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-trzy',
  templateUrl: './trzy.component.html',
  styleUrls: ['./trzy.component.css']
})
export class TrzyComponent implements OnInit {

  lista!:String[];
  visible:boolean = false;
  savenumber!:number;
  selectedText!:String;

  constructor() { }

  ngOnInit(): void {
    this.lista = ["el1","el2","el3","el4"];
  }

  public clicked(value:number):void{
    console.log(value);
    
    if(this.savenumber!=null){
      if(this.savenumber==value){
        this.visible=!this.visible;
      }
      else{
        this.visible = true;
      }
      this.savenumber=value;
      this.selectedText = this.lista[this.savenumber];
    }
    else{
      this.savenumber=value;
      this.selectedText = this.lista[this.savenumber];
      this.visible=true;
    }
    
  }
  public changedData():void{
    this.lista[this.savenumber] = this.selectedText;
    console.log(this.lista.toString());
  }
  public show = true;
}
