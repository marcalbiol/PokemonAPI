import {HttpClient} from '@angular/common/http';
import {Component, OnInit} from '@angular/core';
import {Tipos} from './tipos';
import {LoginService} from "../login/login.service";
import {LoginComponent} from "../login/login.component";

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  tipos: string[] = ['Fuego', 'Agua']

  constructor(private http: HttpClient, private pokedexservice: AppService, public loginService: LoginService,
              private loginComponent: LoginComponent) {
  }


  ngOnInit(): void {
    Tipos;
  }

}
