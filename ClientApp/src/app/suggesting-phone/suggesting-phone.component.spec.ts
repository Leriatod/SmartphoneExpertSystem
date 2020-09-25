import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SuggestingPhoneComponent } from './suggesting-phone.component';

describe('SuggestingPhoneComponent', () => {
  let component: SuggestingPhoneComponent;
  let fixture: ComponentFixture<SuggestingPhoneComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SuggestingPhoneComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SuggestingPhoneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
