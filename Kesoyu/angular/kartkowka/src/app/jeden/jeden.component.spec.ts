import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JedenComponent } from './jeden.component';

describe('JedenComponent', () => {
  let component: JedenComponent;
  let fixture: ComponentFixture<JedenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JedenComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(JedenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
