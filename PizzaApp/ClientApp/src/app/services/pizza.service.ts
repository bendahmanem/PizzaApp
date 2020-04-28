import { Injectable, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Pizza, PizzaResponse } from '../data/interfaces';

@Injectable({
  providedIn: 'root'
})
export class PizzaService implements OnInit {

  private baseUrl = '';
  

  constructor(private http: HttpClient, @Inject('BASE_URL')  _baseUrl: string) {
      this.baseUrl = _baseUrl;
   }

  ngOnInit(): void {
    throw new Error("Method not implemented.");
  }

  getCataloguePizzas() : Observable<PizzaResponse[]> {
     return  this.http.get<PizzaResponse[]>(this.baseUrl + 'api/CataloguePizzas');
  }

  createPizza(pizzas: Pizza) {
    return this.http.post<Pizza>(this.baseUrl + 'api/CataloguePizzas', pizzas);
  }

}
