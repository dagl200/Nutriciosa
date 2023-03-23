import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { API_URL } from '../constants';

@Component({
  selector: 'app-data-empleados',
  templateUrl: './data-empleados.component.html',
  styleUrls: ['./data-empleados.component.css']
})
export class DataEmpleadosComponent {
  public empleados:Empleado[] = [];
  constructor(http: HttpClient) {
    http.get<Empleado[]>(API_URL+"Empleado/getall").subscribe(result => {
      this.empleados = result;
    }, error => console.error(error));

  }
}

interface Empleado {
  id: number,
  nombre: string;
  apellido: string;
  edad: number;
  telefono: string;
  ruta: string;
  camion: string;
  direccion: string;
}