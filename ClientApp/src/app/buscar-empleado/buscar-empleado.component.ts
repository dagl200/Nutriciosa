import { Component, } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormControl,Validators } from '@angular/forms';
import { API_URL } from '../constants';

@Component({
  selector: 'app-buscar-empleado',
  templateUrl: './buscar-empleado.component.html',
  styleUrls: ['./buscar-empleado.component.css']
})
export class BuscarEmpleadoComponent {
  constructor(private http:HttpClient) { }
  buscar_empleado = new FormControl(1,Validators.required)
  public empleado: Empleado = { id: 0, nombre: '', apellido: '', edad: 0, telefono: '', ruta: '', camion: '', direccion: '' };
  public telefono: Telefono = {telefonoID:0,telefono_celular:'',descripcion:'',activo:false}

  onClick(){
    var buscarId = this.buscar_empleado.value
    this.http.get<Empleado>(API_URL+ 'Empleado/getbyid/' +`${buscarId}`).subscribe(result => {
      this.empleado = result;
    }, error => console.error(error));
  }
}


interface Telefono {
  telefonoID:number,
  telefono_celular:string,
  descripcion:string,
  activo:boolean
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
