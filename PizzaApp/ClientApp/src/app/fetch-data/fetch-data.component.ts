import { Component, Inject, OnInit, ChangeDetectorRef } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PizzaService } from '../services/pizza.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Pizza, PizzaResponse } from '../data/interfaces';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent implements OnInit {
  public forecasts: WeatherForecast[];
  public pizzaForm: FormGroup;
  private pizzaToCreate: Pizza = {
    NomPizza: '',
    PrixPizza: 0,
    TaillePizza: 0
  };
  public cataloguePizzas: any
  keys = (obj) => Object.keys(obj);

  constructor(
    http: HttpClient, @Inject('BASE_URL') baseUrl: string,
    private pizzaService: PizzaService,
    private fb: FormBuilder,
    private cd: ChangeDetectorRef) {
    this.pizzaForm = this.fb.group({
      NomPizza: ['', Validators.required],
      TaillePizza: [0, [Validators.required, Validators.pattern(/^-?(0|[1-9]\d*)?$/)]],
      PrixPizza: [0, [Validators.required, Validators.pattern(/^-?(0|[1-9]\d*)?$/)]]
    });
  }
  ngOnInit(): void {
    this.pizzaService.getCataloguePizzas().subscribe(pizzasFromDatabase => {
      this.cataloguePizzas = pizzasFromDatabase;
    })
  }

  log(item) {
    console.log('log: ', item)
  }


  get f() {
    return this.pizzaForm.controls;
  }

  submit() {
    if (this.pizzaForm.status === 'VALID') {
      this.pizzaToCreate.NomPizza = this.pizzaForm.get('NomPizza').value;
      this.pizzaToCreate.PrixPizza = this.pizzaForm.get('PrixPizza').value;
      this.pizzaToCreate.TaillePizza = this.pizzaForm.get('TaillePizza').value;
      this.pizzaService.createPizza(this.pizzaToCreate).subscribe(response => {
        console.log(response);
        this.refreshList();
      })
    }
  }

  refreshList() {
    this.pizzaService.getCataloguePizzas().subscribe(pizzasFromDatabase => {
      this.cataloguePizzas = pizzasFromDatabase;
    })
  }

  modifyPizza(id: number) {

  }

  deletePizza(id: number) {
    
  }

  resetValue() {
    console.log(this.pizzaForm);
    this.pizzaForm.reset({ NomPizza: '', TaillePizza: 0, PrixPizza: 0 });
  }

}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
