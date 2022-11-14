import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AtrakcjeComponent } from './atrakcje/atrakcje.component';
import { GaleriaComponent } from './galeria/galeria.component';
import { GlownaComponent } from './glowna/glowna.component';
import { HistoriaComponent } from './historia/historia.component';
import { MapaComponent } from './mapa/mapa.component';
import { NaglowekComponent } from './naglowek/naglowek.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

const routes: Routes = [
  { path : 'naglowek', redirectTo:'/naglowek/glowna', pathMatch:'full' },
  { path : 'naglowek', component:NaglowekComponent, children : [ { path:'historia', component:HistoriaComponent }, { path:'galeria', component:GaleriaComponent }, { path:'atrakcje', component:AtrakcjeComponent }, { path:'mapa', component:MapaComponent }, { path:'glowna', component:GlownaComponent } ] }, 
  { path : '', redirectTo:'/naglowek/glowna', pathMatch:'full' },
  { path: '**', component:PageNotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
