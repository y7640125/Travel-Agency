import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminFlightModelComponent } from './admin-flight-model.component';

describe('AdminFlightModelComponent', () => {
  let component: AdminFlightModelComponent;
  let fixture: ComponentFixture<AdminFlightModelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminFlightModelComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminFlightModelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
