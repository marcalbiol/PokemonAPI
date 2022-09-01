import {HttpClientModule} from '@angular/common/http';
import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {AppComponent} from './app.component';
import {PokedexService} from './app.service';
import {EntrenadoresComponent} from './entrenadores/entrenadores.component';
import {NavComponent} from './nav/nav.component';

@NgModule({
  declarations: [
    AppComponent,
    EntrenadoresComponent,
    NavComponent
  ],
  imports: [
    BrowserModule, HttpClientModule
  ],
  providers: [PokedexService],
  bootstrap: [AppComponent]
})
export class AppModule {
}
