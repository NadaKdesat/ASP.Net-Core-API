import { Component } from '@angular/core';
import { Category, DataServiesService } from '../Services/data-servies.service';

@Component({
  selector: 'app-category',
  standalone: false,
  templateUrl: './category.component.html',
  styleUrl: './category.component.css'
})

export class CategoryComponent {
  categories:Category[] =[];
  constructor(private _service: DataServiesService) { }

  ngOnInit(){
    this.getAllCategories();
  }

  getAllCategories() {
    this._service.getAllCategories().subscribe((data) => {
      this.categories = data;
    })
  }

  deleteCategory(id:number) {
    this._service.deleteCategory(id).subscribe(() => {
      alert("Category deleted successfully");
      this.getAllCategories(); 
    })
  }

}
