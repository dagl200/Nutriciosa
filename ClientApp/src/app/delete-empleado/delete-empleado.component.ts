import { Component, OnInit } from '@angular/core';
import { FormControl,Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { API_URL } from '../constants';

@Component({
  selector: 'app-delete-empleado',
  templateUrl: './delete-empleado.component.html',
  styleUrls: ['./delete-empleado.component.css']
})
export class DeleteEmpleadoComponent {

  constructor(private http:HttpClient) { }
  empleadoId = new FormControl(0,Validators.required);
  

  onClick() {

    var id = this.empleadoId.value;

    this.http.delete(API_URL+ 'Empleado/delete/' +`${id}`).subscribe(() => {
      console.log('Empleado eliminado exitosamente');
    });
  };

}
