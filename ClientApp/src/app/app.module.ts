import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { DataEmpleadosComponent } from './data-empleados/data-empleados.component';
import { AddEmpleadoComponent } from './add-empleado/add-empleado.component';
import { DeleteEmpleadoComponent } from './delete-empleado/delete-empleado.component';
import { AddNumberComponent } from './add-number/add-number.component';
import { BuscarEmpleadoComponent } from './buscar-empleado/buscar-empleado.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    DataEmpleadosComponent,
    AddEmpleadoComponent,
    AddNumberComponent,
    DeleteEmpleadoComponent,
    BuscarEmpleadoComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'tabla', component:  DataEmpleadosComponent},
      { path: 'editar', component:  AddEmpleadoComponent},
      { path: 'number', component:AddNumberComponent},
      { path: 'buscar', component:BuscarEmpleadoComponent},
      { path: '**', component:HomeComponent}

    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
