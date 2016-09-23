import { Component }          from '@angular/core';

@Component({
  selector: 'my-app',

  template: `
    <head><base href="/"/> </head>
    <h2>{{title}}</h2>
    <nav>
        <a routerLink="/apuestas" routerLinkActive="active">Apuestas</a>
        <a routerLink="/clientes" routerLinkActive="active">Clientes</a>
    </nav>
    <router-outlet></router-outlet>
  `,
  styleUrls: ['app/app.component.css']
})
export class AppComponent {
  title = 'Bet on it!';
}