import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DwaComponent } from './dwa/dwa.component';
import { JedenComponent } from './jeden/jeden.component';
import { NotFoundComponent } from './not-found/not-found.component';

const routes: Routes = [
  { path: 'jeden', component:JedenComponent },
  { path: 'dwa', component:DwaComponent },
  { path: '', redirectTo:'/jeden', pathMatch:'full' },
  { path: '**', component:NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
