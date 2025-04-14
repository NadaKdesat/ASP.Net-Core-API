import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ViewCategoryComponent } from './view-category/view-category.component';

const routes: Routes = [
  { path: 'category/:id', component: ViewCategoryComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
