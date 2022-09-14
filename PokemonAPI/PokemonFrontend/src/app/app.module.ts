import {HttpClientModule} from '@angular/common/http';
import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {AppComponent} from './app.component';
import {PokedexService} from './app.service';
import {EntrenadoresComponent} from './entrenadores/entrenadores.component';
import {NavComponent} from './nav/nav.component';
import {CommonModule} from '@angular/common';
import {ZonasComponent} from './zonas/zonas.component';
import {ZonaService} from "./zonas/zonas.service";
import {MapaComponent} from './mapa/mapa.component';
import {MapaService} from "./mapa/mapa.service";
import {ModalComponent} from './mapa/modal/modal.component';

//TODO: IMPLEMENTAR ROUTERLINK PARA NAVEGAR A OTRAS PAGINAS

@NgModule({
  declarations: [
    AppComponent,
    EntrenadoresComponent,
    NavComponent,
    ZonasComponent,
    MapaComponent,
    ModalComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, CommonModule
  ],
  providers: [PokedexService, ZonaService, MapaService],
  bootstrap: [AppComponent]
})
export class AppModule {
}
