import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';
//angular.module('MyApp', ['ngMaterial', 'ngMessages', 'material.svgAssetsCache']);
import {} from '@angular/module/ngMessages'
import { Apuesta }                from './apuesta';
import { ApuestaService }         from './apuesta.service';

@Component({
  selector: 'my-apuestas',
  templateUrl: 'app/apuestas.component.html',
  styleUrls:  ['app/apuestas.component.css']
})
export class ApuestasComponent implements OnInit {
  apuestas: Apuesta[];
  selectedApuesta: Apuesta;

  constructor(
      private apuestaService: ApuestaService,
      private router: Router) { }

  getApuestas(): void {
      this.apuestaService
          .getApuestas()
        .then(apuestas => this.apuestas = apuestas);
  }


  delete(apuesta: Apuesta): void {
      this.apuestaService
          .delete(apuesta.id)
          .then(() => {
              this.apuestas = this.apuestas.filter(apuesta2 => apuesta2 !== apuesta);
          if (this.selectedApuesta === apuesta) { this.selectedApuesta = null; }
        });
  }

  ngOnInit(): void {
    this.getApuestas();
  }

  onSelect(apuesta: Apuesta): void {
    this.selectedApuesta = apuesta;
  }

  gotoDetail(): void {
      if (!this.selectedApuesta) {
          this.router.navigate(['/apuesta-details']);
      } else {
          this.router.navigate(['/apuesta-details', this.selectedApuesta.id]);
      }

    
  }
}