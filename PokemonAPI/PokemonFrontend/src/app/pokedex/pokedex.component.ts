import {Component, OnInit} from '@angular/core';
import {PokedexService} from "./pokedex.service";

@Component({
  selector: 'app-pokedex',
  templateUrl: './pokedex.component.html',
  styleUrls: ['./pokedex.component.css']
})
export class PokedexComponent implements OnInit {
  pokedex!: any;
  show: boolean = true;

  constructor(private pokedexservice: PokedexService) {
  }

  // al levantar el servidor se ejecuta ->
  ngOnInit() {
    this.pokedexservice.getPokedex().subscribe(value => {
      this.pokedex = value
      console.log(value)
    })
  }

  mostrarPokedex(): void {
    this.show = this.show ? false : true
  }
}
