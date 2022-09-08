import {Component, OnInit} from '@angular/core';
import {ZonaService} from "../zonas/zonas.service";

@Component({
  selector: 'app-mapa',
  templateUrl: './mapa.component.html',
  styleUrls: ['./mapa.component.css']
})
export class MapaComponent implements OnInit {

  zona!: any;

  constructor(private zonaService: ZonaService) {
  }

  ngOnInit(): void {

  }


  openZona() {
    this.zonaService.getZona().subscribe(value => {
      this.zona = value
      console.log(value)
    })
  }

}
