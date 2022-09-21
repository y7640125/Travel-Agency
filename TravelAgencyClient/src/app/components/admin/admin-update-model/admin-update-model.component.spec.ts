import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminUpdateModelComponent } from './admin-update-model.component';

describe('AdminUpdateModelComponent', () => {
  let component: AdminUpdateModelComponent;
  let fixture: ComponentFixture<AdminUpdateModelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminUpdateModelComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminUpdateModelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
