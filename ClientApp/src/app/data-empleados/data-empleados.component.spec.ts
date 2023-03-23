import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DataEmpleadosComponent } from './data-empleados.component';

describe('DataEmpleadosComponent', () => {
  let component: DataEmpleadosComponent;
  let fixture: ComponentFixture<DataEmpleadosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DataEmpleadosComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DataEmpleadosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
