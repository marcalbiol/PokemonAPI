import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Router} from '@angular/router';
import { SubscriptionLog } from 'rxjs/internal/testing/SubscriptionLog';
import {pokedex} from "./pokedex";
import {map} from  'rxjs/operators';

@Injectable()
export class PokedexService {

  private urlEndPoint: string = 'https://localhost:7001/api'  // servidor de backend
  private httpHeaders = new HttpHeaders({ 'Content-Type': 'application/json' })



  constructor(private http: HttpClient, private router: Router) {
  }

    getPokedex(): Observable<pokedex[]>{
    return this.http.get<pokedex[]>(this.urlEndPoint + "/Pokedex/AllData")
  }
/*
  getRegiones(): Observable<region[]> {
    return this.http.get<pokedex[]>(this.urlEndPoint + "/Region")
  }

 */

}