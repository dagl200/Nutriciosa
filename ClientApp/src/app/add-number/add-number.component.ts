import { Component } from '@angular/core';
import { FormBuilder,Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { API_URL } from '../constants';
import { FormControl } from '@angular/forms';


@Component({
  selector: 'app-add-number',
  templateUrl: './add-number.component.html',
  styleUrls: ['./add-number.component.css']
})
export class AddNumberComponent {
  constructor(private http:HttpClient,private fb: FormBuilder) { }

  telefonoForm = this.fb.group({
    telefono_celular:['',Validators.required],
    descripcion:[''],
    activo:['']

  });

  onSubmit() {
    const newTelefono = {
      Telefono_celular: this.telefonoForm.value.telefono_celular,
      Descripcion: this.telefonoForm.value.descripcion,
      Activo: (this.telefonoForm.value.activo ==='true' ? true: false)
    }

    this.http.post(API_URL+ 'Empleado/telefono', newTelefono).subscribe(() => {
      console.log('Telefono agregado exitosamente');
      this.telefonoForm.reset()
    });

  };

  telId = new FormControl(0,Validators.required);

  onClick(){

    var id = this.telId.value;
    this.http.delete(API_URL+ 'Empleado/telefono/'+`${id}`).subscribe(()=> {
      console.log('Telefono borrado existosamente');
    })
  }

}
