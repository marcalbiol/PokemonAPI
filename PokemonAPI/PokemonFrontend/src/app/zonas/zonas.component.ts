import { Component, OnInit } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {PokedexService} from "../app.service";
import {ZonaService} from "./zonas.service";

@Component({
  selector: 'app-zonas',
  templateUrl: './zonas.component.html',
  styleUrls: ['./zonas.component.css']
})
export class ZonasComponent implements OnInit {

  zona!: any;

  constructor(private http: HttpClient, private pokedexservice: PokedexService,
              private zonaService: ZonaService) { }

  ngOnInit(): void {
    this.zonaService.getZona().subscribe(value => {
      this.zona = value
      console.log(value)
    })
  }
}
