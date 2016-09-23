import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';

import { Apuesta }        from './apuesta';
import { ApuestaService } from './apuesta.service';
import {Cliente} from './cliente';
import {ClienteService} from './cliente.service';

@Component({
  selector: 'my-apuesta-detail',
  templateUrl: 'app/apuesta-detail.component.html',
  styleUrls: ['app/apuesta-detail.component.css']
})
export class ApuestaDetailComponent implements OnInit {
    apuesta: Apuesta;
    create: boolean;
    clientes: Cliente[];
    vacio: boolean;

  constructor(
      private apuestaService: ApuestaService,
      private clienteService: ClienteService,
    private route: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.route.params.forEach((params: Params) => {
        let id = +params['id'];
        if (id) {
            this.create = false;
            this.apuestaService.getApuesta(id)
                .then(apuesta => this.apuesta = apuesta);
            
        } else {
            this.apuesta = new Apuesta();
            this.create = true;
        }        
      });
    this.route.params.forEach((params: Params) => {
        this.clienteService.getClientes().then(clientes => this.clientes = clientes)
    });
}
  

  save(): void {
      if (!this.apuesta.textoUsuario || !this.apuesta.cantidad || !this.apuesta.UsrID || !this.apuesta.fechaApuesta) {
          this.vacio = true;
      } else {
          this.vacio = false;
          this.apuestaService.update(this.apuesta)
              .then(this.goBack);
      }
  }
  add(): void {
      if (!this.apuesta.textoUsuario || !this.apuesta.cantidad || !this.apuesta.UsrID || this.apuesta.fechaApuesta) {
          this.vacio = true;
      } else {
          this.vacio = false;
          this.apuestaService.create(this.apuesta)
              .then(this.goBack);

      }
      
  }

  goBack(): void {
    window.history.back();
  }
}