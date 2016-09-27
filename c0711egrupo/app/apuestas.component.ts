import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';
//angular.module('MyApp', ['ngMaterial', 'ngMessages', 'material.svgAssetsCache']);
import {} from '@angular/module/ngMessages'
import { Mensaje }                from './Mensaje';
import { MensajeService }         from './Mensaje.service';

@Component({
  selector: 'my-Mensajes',
  templateUrl: 'app/Mensajes.component.html',
  styleUrls:  ['app/Mensajes.component.css']
})
export class MensajesComponent implements OnInit {
  Mensajes: Mensaje[];
  selectedMensaje: Mensaje;

  constructor(
      private MensajeService: MensajeService,
      private router: Router) { }

  getMensajes(): void {
      this.MensajeService
          .getMensajes()
        .then(Mensajes => this.Mensajes = Mensajes);
  }


  delete(Mensaje: Mensaje): void {
      this.MensajeService
          .delete(Mensaje.id)
          .then(() => {
              this.Mensajes = this.Mensajes.filter(Mensaje2 => Mensaje2 !== Mensaje);
          if (this.selectedMensaje === Mensaje) { this.selectedMensaje = null; }
        });
  }

  ngOnInit(): void {
    this.getMensajes();
  }

  onSelect(Mensaje: Mensaje): void {
    this.selectedMensaje = Mensaje;
  }

  gotoDetail(): void {
      if (!this.selectedMensaje) {
          this.router.navigate(['/Mensaje-details']);
      } else {
          this.router.navigate(['/Mensaje-details', this.selectedMensaje.id]);
      }

    
  }
}