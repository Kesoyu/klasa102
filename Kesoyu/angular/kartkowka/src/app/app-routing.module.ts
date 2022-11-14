import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DwaComponent } from './dwa/dwa.component';
import { JedenComponent } from './jeden/jeden.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { TrzyComponent } from './trzy/trzy.component';

const routes: Routes = [
  { path: 'jeden', component:JedenComponent },
  { path: 'dwa', component:DwaComponent },
  { path: 'trzy', component:TrzyComponent },
  { path: '', redirectTo:'/jeden', pathMatch:'full' },
  { path: '**', component:NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
