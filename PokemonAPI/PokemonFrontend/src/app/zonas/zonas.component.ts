import {Component, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {ZonaService} from "./zonas.service";

@Component({
  selector: 'app-zonas',
  templateUrl: './zonas.component.html',
  styleUrls: ['./zonas.component.css']
})
export class ZonasComponent implements OnInit {

  zona!: any;
  pokedex!: any;

  constructor(private http: HttpClient,
              private zonaService: ZonaService) {
  }

  ngOnInit(): void {
    this.zonaService.getZona().subscribe(value => {
      console.log(value[0])
      this.zona = value;
    })
  }

  myFunc() {
    alert("hola")
  }


}
