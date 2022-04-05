import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [
    {
      Tema: ".NET 5",
      Local: "Belo Horizonte",
    },
    {
      Tema: "Angular",
      Local: "São Paulo",
    },
    {
      Tema: "News",
      Local: "Rio de Janeiro",
    }
  ]

  constructor() { }

  ngOnInit() {
  }

}
