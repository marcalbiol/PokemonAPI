import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { PokedexService } from '../app.service';
import { pokedex } from '../pokedex';
import { Tipos } from './tipos';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  Tipos!: Tipos[];

  constructor(private http: HttpClient, private pokedexservice: PokedexService) { }

  ngOnInit(): void {
    Tipos;
  }

}
