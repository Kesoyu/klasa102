import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NaglowekComponent } from './naglowek/naglowek.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { HistoriaComponent } from './historia/historia.component';
import { GaleriaComponent } from './galeria/galeria.component';
import { AtrakcjeComponent } from './atrakcje/atrakcje.component';
import { MapaComponent } from './mapa/mapa.component';
import { StopkaComponent } from './stopka/stopka.component';
import { GlownaComponent } from './glowna/glowna.component';

@NgModule({
  declarations: [
    AppComponent,
    NaglowekComponent,
    PageNotFoundComponent,
    HistoriaComponent,
    GaleriaComponent,
    AtrakcjeComponent,
    MapaComponent,
    StopkaComponent,
    GlownaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
