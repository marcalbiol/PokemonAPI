import {HttpClient} from '@angular/common/http';
import {Component, OnInit} from '@angular/core';
import {PokedexService} from './app.service';
import {pokedex} from "./pokedex.interface";

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
    this.pokedexservice.getPokedex().subscribe(
      res => {
        this.pokedex = res
        console.log(this.pokedex[2])
  }, err => {
        console.log(err)
      }
    );
  }

  getData(){
    this.pokedexservice.getPokedex().subscribe((res:any)=>{
      this.pokedex = res.tipos;
    });
  }





  mostrarPokedex(): void {
    this.show = this.show ? false : true
  }

}

