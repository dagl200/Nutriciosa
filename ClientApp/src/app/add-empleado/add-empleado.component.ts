import { Component,inject,Inject} from '@angular/core';
import {FormBuilder, Validators} from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { DeleteEmpleadoComponent } from '../delete-empleado/delete-empleado.component';
import { API_URL } from '../constants';

@Component({
  selector: 'app-add-empleado',
  templateUrl: './add-empleado.component.html',
  styleUrls: ['./add-empleado.component.css']
})
export class AddEmpleadoComponent{

  constructor(private http:HttpClient,private fb: FormBuilder) { }

  empleadoForm = this.fb.group({
    Nombre: ['',Validators.required],
    Apellido: ['',Validators.required],
    Edad: [0,Validators.required],
    Telefono: ['',Validators.required],
    Camion: [''],
    Ruta: [''],
    Direccion: ['']
  });

  
  onSubmit() {
    const newEmpleado = {
      Nombre: this.empleadoForm.value.Nombre,
      Apellido: this.empleadoForm.value.Apellido,
      Edad: this.empleadoForm.value.Edad,
      Telefono: this.empleadoForm.value.Telefono,
      Camion: this.empleadoForm.value.Camion,
      Ruta: this.empleadoForm.value.Ruta,
      Direccion: this.empleadoForm.value.Direccion
    };
  
    
    this.http.post(API_URL +'Empleado/Create', newEmpleado).subscribe(() => {
      console.log('Empleado agregado exitosamente');
      this.empleadoForm.reset()
    });
  }
  
  
}


