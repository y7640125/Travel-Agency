import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminCustomerServiceComponent } from './admin-customer-service.component';

describe('AdminCustomerServiceComponent', () => {
  let component: AdminCustomerServiceComponent;
  let fixture: ComponentFixture<AdminCustomerServiceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminCustomerServiceComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminCustomerServiceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
