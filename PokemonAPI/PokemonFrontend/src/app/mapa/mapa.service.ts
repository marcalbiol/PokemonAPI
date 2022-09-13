import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MapaService {

  private urlEndPoint: string = 'https://localhost:7001/api'  // servidor de backend

  constructor(private http: HttpClient) {
  }

  deletePokemon(id: number) {
    console.log(this.urlEndPoint + "/Zona/DeletePokemonFromZona/" + id)
    return this.http.delete(this.urlEndPoint + "/Zona/DeletePokemonFromZona/" + id)
  }

}

