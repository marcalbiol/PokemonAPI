import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {Observable} from "rxjs";
import {User} from "./user";
import swal from 'sweetalert2';
import {FormGroup} from "@angular/forms";
import {LoginComponent} from "./login.component";

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  _user = User;
  private urlEndPoint: string = 'https://localhost:7001/api'  // servidor de backend

  constructor(private http: HttpClient) {
  }


  create(user: User) {
    const httpOptions = {
      headers: new HttpHeaders({'Content-Type': 'application/json'})
    }
    return this.http.post<User>(this.urlEndPoint + "/Register", JSON.stringify(user), httpOptions)
      .subscribe(value => {
        console.log(`Usuario ${user.username} creado con éxito`)
      })

  }
}
