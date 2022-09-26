import {HttpClientModule} from '@angular/common/http';
import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {AppComponent} from './app.component';
import {EntrenadoresComponent} from './entrenadores/entrenadores.component';
import {NavComponent} from './nav/nav.component';
import {CommonModule} from '@angular/common';
import {ZonasComponent} from './zonas/zonas.component';
import {ZonaService} from "./zonas/zonas.service";
import {MapaComponent} from './mapa/mapa.component';
import {MapaService} from "./mapa/mapa.service";
import {ModalComponent} from './mapa/modal/modal.component';
import {LoginComponent} from './login/login.component';
import {ReactiveFormsModule} from "@angular/forms";
import {LoginService} from "./login/login.service";
import {RouterModule, Routes} from "@angular/router";
import {PokedexComponent} from './pokedex/pokedex.component';
import {PokedexService} from "./pokedex/pokedex.service";

//TODO: IMPLEMENTAR ROUTERLINK PARA NAVEGAR A OTRAS PAGINAS

const router: Routes =
  [{path: 'index', component: PokedexComponent},
    {path: 'login', component: LoginComponent}
  ]

// @ts-ignore
@NgModule({
  declarations: [
    AppComponent,
    EntrenadoresComponent,
    NavComponent,
    ZonasComponent,
    MapaComponent,
    ModalComponent,
    LoginComponent,
    PokedexComponent
  ],
  exports: [RouterModule],
  imports: [
    BrowserModule, HttpClientModule, CommonModule, ReactiveFormsModule,
    RouterModule.forRoot(router),
  ],
  providers: [PokedexService, ZonaService, MapaService, LoginService, LoginComponent],
  bootstrap: [AppComponent]
})
export class AppModule {
}
