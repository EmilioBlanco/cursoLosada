import { Component }          from '@angular/core';

@Component({
  selector: 'my-app',

  template: `
    <head><base href="/"/> </head>
    <h2>{{title}}</h2>
    <nav>
        <a routerLink="/mensajes" routerLinkActive="active">Mensajes</a>
        
    </nav>
    <select id="cmbSelectedCliente" [(ngModel)]="usuario.id">
        <option *ngFor="let usuario of usuarios" [value]="usuario.id">{{usuario.nombre}}</option>
    </select>    
    <router-outlet></router-outlet>
  `,
  styleUrls: ['app/app.component.css']
})
export class AppComponent {
  title = 'Nhapa Mail';
}