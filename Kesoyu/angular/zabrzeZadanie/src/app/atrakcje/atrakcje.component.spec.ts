import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AtrakcjeComponent } from './atrakcje.component';

describe('AtrakcjeComponent', () => {
  let component: AtrakcjeComponent;
  let fixture: ComponentFixture<AtrakcjeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AtrakcjeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AtrakcjeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
