import { ComponentFixture, TestBed } from '@angular/core/testing';
import { NgModel } from '@angular/forms';

import { TrzyComponent } from './trzy.component';

describe('TrzyComponent', () => {
  let component: TrzyComponent;
  let fixture: ComponentFixture<TrzyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TrzyComponent, NgModel ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TrzyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
