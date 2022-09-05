import {HttpClientModule} from '@angular/common/http';
import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {AppComponent} from './app.component';
import {PokedexService} from './app.service';
import {EntrenadoresComponent} from './entrenadores/entrenadores.component';
import {NavComponent} from './nav/nav.component';
import {CommonModule} from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    EntrenadoresComponent,
    NavComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, CommonModule
  ],
  providers: [PokedexService],
  bootstrap: [AppComponent]
})
export class AppModule {
}
