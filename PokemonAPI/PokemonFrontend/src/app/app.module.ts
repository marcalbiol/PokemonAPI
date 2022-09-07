import {HttpClientModule} from '@angular/common/http';
import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {AppComponent} from './app.component';
import {PokedexService} from './app.service';
import {EntrenadoresComponent} from './entrenadores/entrenadores.component';
import {NavComponent} from './nav/nav.component';
import {CommonModule} from '@angular/common';
import { ZonasComponent } from './zonas/zonas.component';
import {ZonaService} from "./zonas/zonas.service";

//TODO: IMPLEMENTAR ROUTERLINK PARA NAVEGAR A OTRAS PAGINAS

@NgModule({
  declarations: [
    AppComponent,
    EntrenadoresComponent,
    NavComponent,
    ZonasComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, CommonModule
  ],
  providers: [PokedexService, ZonaService],
  bootstrap: [AppComponent]
})
export class AppModule {
}
