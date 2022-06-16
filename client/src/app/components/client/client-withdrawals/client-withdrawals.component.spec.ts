import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientWithdrawalsComponent } from './client-withdrawals.component';

describe('ClientWithdrawalsComponent', () => {
  let component: ClientWithdrawalsComponent;
  let fixture: ComponentFixture<ClientWithdrawalsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ClientWithdrawalsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ClientWithdrawalsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
