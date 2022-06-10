import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientDepositFormComponent } from './client-deposit-form.component';

describe('ClientDepositFormComponent', () => {
  let component: ClientDepositFormComponent;
  let fixture: ComponentFixture<ClientDepositFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ClientDepositFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ClientDepositFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
