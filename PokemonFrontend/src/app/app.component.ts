import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { PokedexService } from './app.service';
import { pokedex } from './pokedex';




@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {

  pokedex!: pokedex[];

  constructor(private http: HttpClient, private pokedexservice: PokedexService) { }

  ngOnInit() {
    this.pokedexservice.getPokedex().subscribe(
      pok => this.pokedex = pok)
    }

}

