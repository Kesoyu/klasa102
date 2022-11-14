import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EdycjaComponent } from './edycja/edycja.component';
import { ListaComponent } from './lista/lista.component';
import { NajlepszyComponent } from './najlepszy/najlepszy.component';
import { NotFoundComponent } from './not-found/not-found.component';

const routes: Routes = [
  { path: 'samochody', component:ListaComponent },
  { path: 'najlepszy', component:NajlepszyComponent },
  { path: 'edycja', component:EdycjaComponent },
  { path: '', redirectTo:'/samochody', pathMatch:'full' },
  { path: '**', component:NotFoundComponent }
];

//Przedostatnia linijka to siłowe przekierowanie na stronę główną, którą tutaj nie jest goły adres tylko lista samochodów
//Ostatnia to zabezpieczenie jakby ktoś chciał wejść na stronę, która nie istnieje (np. wpisałby localhost:4200/autobusy)

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
