import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientWithdrawalFormComponent } from './client-withdrawal-form.component';

describe('ClientWithdrawalFormComponent', () => {
  let component: ClientWithdrawalFormComponent;
  let fixture: ComponentFixture<ClientWithdrawalFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ClientWithdrawalFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ClientWithdrawalFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
