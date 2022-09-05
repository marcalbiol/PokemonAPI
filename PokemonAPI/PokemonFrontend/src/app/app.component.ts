import {HttpClient} from '@angular/common/http';
import {Component, OnInit} from '@angular/core';
import { SubscriptionLog } from 'rxjs/internal/testing/SubscriptionLog';
import {PokedexService} from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {

  pokedex!: any;
  show: boolean = true;

  constructor(private http: HttpClient, private pokedexservice: PokedexService) {
  }

  // al levantar el servidor se ejecuta ->
  ngOnInit() {
    this.pokedexservice.getPokedex().subscribe(val => {
      this.pokedex = val
      console.log(val[2])
    })
  }

  mostrarPokedex(): void {
    this.show = this.show ? false : true
  }

}

