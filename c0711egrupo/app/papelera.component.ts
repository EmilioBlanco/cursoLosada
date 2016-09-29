import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';
//angular.module('MyApp', ['ngMaterial', 'ngMessages', 'material.svgAssetsCache']);
import {} from '@angular/module/ngMessages'
import { Mensaje }                from './mensaje';
import { MensajeService }         from './mensaje.service';

@Component({
  selector: 'my-mensajes',
  templateUrl: 'app/mensajes.component.html',
  styleUrls:  ['app/mensajes.component.css']
})
export class PapeleraComponent implements OnInit {
  mensajes: Mensaje[];
  selectedMensaje: Mensaje;

  constructor(
      private mensajeService: MensajeService,
      private router: Router) { }

  getMensajes(): void {
      this.mensajeService
          .getPapelera()
        .then(mensajes => this.mensajes = mensajes);
  }


  delete(mensaje: Mensaje): void {
      this.mensajeService
          .delete(mensaje.id)
          .then(() => {
              this.mensajes = this.mensajes.filter(msj => msj !== mensaje);
          if (this.selectedMensaje === mensaje) { this.selectedMensaje = null; }
        });
  }

  ngOnInit(): void {
    this.getMensajes();
  }

  onSelect(mensaje: Mensaje): void {
    this.selectedMensaje = mensaje;
  }

  gotoDetail(): void {
      if (!this.selectedMensaje) {
          this.router.navigate(['/mensaje-details']);
      } else {
          this.router.navigate(['/mensaje-details', this.selectedMensaje.id]);
      }

    
  }
}