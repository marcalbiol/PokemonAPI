import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Router} from '@angular/router';
import {zona} from "./zona"

@Injectable()
export class ZonaService {

  id: number = 1;
  private urlEndPoint: string = 'https://localhost:7001/api'  // servidor de backend
  private httpHeaders = new HttpHeaders({'Content-Type': 'application/json'})


  constructor(private http: HttpClient, private router: Router) {
  }

  getZona(): Observable<zona[]> {
    return this.http.get<zona[]>(this.urlEndPoint + "/Zona")
  }


  getZonaById(): Observable<zona[]> {
    return this.http.get<zona[]>(this.urlEndPoint + "/Zona" + "/1")

  }

}
