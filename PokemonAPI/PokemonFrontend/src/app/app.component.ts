import {HttpClient} from '@angular/common/http';
import {Component, OnInit} from '@angular/core';
import {PokedexService} from './app.service';
import {pokedex, region} from './pokedex';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {

  pokedex!: pokedex[];
  region!: region[]

  show: boolean = true;


  constructor(private http: HttpClient, private pokedexservice: PokedexService) {
  }

  // al levantar el servidor se ejecuta ->
  ngOnInit() {
    this.pokedexservice.getPokedex().subscribe(
      pok => this.pokedex = pok)

  }

  mostrarPokedex(): void {
    this.show = (this.show == true) ? false : true
  }

}

