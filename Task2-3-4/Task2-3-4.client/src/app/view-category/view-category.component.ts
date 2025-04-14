import { Component } from '@angular/core';
import { Category, DataServiesService } from '../Services/data-servies.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-view-category',
  standalone: false,
  templateUrl: './view-category.component.html',
  styleUrl: './view-category.component.css'
})
export class ViewCategoryComponent {
  categories!: Category;
  constructor(private _service: DataServiesService, private _route: ActivatedRoute) { }

  ngOnInit() {
    const id = Number(this._route.snapshot.paramMap.get('id'));
    this.getCategory(id);
  }


  getCategory(id: number) {
    this._service.getCategoryById(id).subscribe((data) => {
      this.categories = data;
    })
  }
}
