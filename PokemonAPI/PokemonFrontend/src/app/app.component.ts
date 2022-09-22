import {HttpClient} from '@angular/common/http';
import {Component, OnInit} from '@angular/core';
import {PokedexService} from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {

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

