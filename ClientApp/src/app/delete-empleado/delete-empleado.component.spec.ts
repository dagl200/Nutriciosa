import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteEmpleadoComponent } from './delete-empleado.component';

describe('DeleteEmpleadoComponent', () => {
  let component: DeleteEmpleadoComponent;
  let fixture: ComponentFixture<DeleteEmpleadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeleteEmpleadoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeleteEmpleadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
