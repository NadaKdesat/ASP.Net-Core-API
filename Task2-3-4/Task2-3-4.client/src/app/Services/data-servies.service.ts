import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

export interface Category {
  categoryId: number;
  categoryName: string;
  categoryDescription: string;
}

@Injectable({
  providedIn: 'root'
})
export class DataServiesService {
  constructor(private http: HttpClient) {}

  getAllCategories(): Observable<Category[]> {
    return this.http.get<Category[]>("https://localhost:7119/api/Category/AllCategory");
  }

  getCategoryById(id: number): Observable<Category> {
    return this.http.get<Category>(`https://localhost:7119/api/Category/getCategoryById/${id}`);
  }

  deleteCategory(id: number): Observable<Category> {
    return this.http.delete<Category>(`https://localhost:7119/api/Category/deleteCategory/${id}`);
  }
}
