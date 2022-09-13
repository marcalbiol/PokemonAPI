import { HttpClient } from '@angular/common/http';
import {Component, OnInit} from '@angular/core';
import {ZonaService} from "../zonas/zonas.service";
import {MapaService} from "./mapa.service";

@Component({
  selector: 'app-mapa',
  templateUrl: './mapa.component.html',
  styleUrls: ['./mapa.component.css']
})
export class MapaComponent implements OnInit {

  zona!: any;

  constructor(private zonaService: ZonaService,
              private mapaService: MapaService
              ) {
  }

  ngOnInit(): void {

  }

  deletePokemon(id: number) {
    console.log(id)
    this.mapaService.deletePokemon(id);
  }

  openZona() {
    this.zonaService.getZona().subscribe(value => {
      this.zona = value
      console.log(value)
    })
  }

}
