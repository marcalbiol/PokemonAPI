import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {Router} from "@angular/router";
import {Observable} from "rxjs";
import {pokedex} from "./pokedex";

@Injectable({
  providedIn: 'root'
})
export class PokedexService {

  private urlEndPoint: string = 'https://localhost:7001/api'  // servidor de backend
  private httpHeaders = new HttpHeaders({'Content-Type': 'application/json'})

  constructor(private http: HttpClient, private router: Router) { }

  getPokedex(): Observable<pokedex[]> {
    return this.http.get<pokedex[]>(this.urlEndPoint + "/Pokedex/AllData")
  }
}
