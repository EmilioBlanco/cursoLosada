import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';

import { Cliente }                from './cliente';
import { ClienteService }         from './cliente.service';

@Component({
  selector: 'my-clientes',
  templateUrl: 'app/clientes.component.html',
  styleUrls:  ['app/clientes.component.css']
})
export class ClientesComponent implements OnInit {
  clientes: Cliente[];
  selectedCliente: Cliente;
  puedeBorrar: boolean;
  noDeleted: boolean;

  constructor(
    private clienteService: ClienteService,
    private router: Router) { }

  getClientes(): void {
      this.clienteService
          .getClientes()
        .then(clientes => this.clientes = clientes);
  }

  delete(cliente: Cliente): void {

      this.puedeBorrar = false;
      debugger
      var test = "br";
      this.clienteService.delete(cliente.id)
          .then(x => {
              this.puedeBorrar = x;
              if (this.puedeBorrar) {
                  this.noDeleted = false;
              this.clientes = this.clientes.filter(cliente2 => cliente2 !== cliente);
              if (this.selectedCliente === cliente) { this.selectedCliente = null; }
      } else {
          this.noDeleted = true;
          }
      });
      

      /*this.clienteService
          .delete(cliente.id)
          .then(() => {
              this.clientes = this.clientes.filter(cliente2 => cliente2 !== cliente);
              if (this.selectedCliente === cliente) {
                  this.selectedCliente = null;
              }
          });*/
  }

  ngOnInit(): void {
    this.getClientes();
  }

  onSelect(cliente: Cliente): void {
      this.selectedCliente = cliente;
      this.noDeleted = false;
  }

  gotoDetail(): void {
      if (!this.selectedCliente) {
          this.router.navigate(['/cliente-details']);
      } else {
          this.router.navigate(['/cliente-details', this.selectedCliente.id]);
      }
    
  }
}