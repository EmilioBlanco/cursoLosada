import {Cliente} from './cliente';
export class Apuesta {
  id: number;
  fechaApuesta: string;
  textoUsuario: string;
  cantidad: number;
  UsrID: number;
  cliente: Cliente;
}