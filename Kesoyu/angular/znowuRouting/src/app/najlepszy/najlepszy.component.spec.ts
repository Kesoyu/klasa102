import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NajlepszyComponent } from './najlepszy.component';

describe('NajlepszyComponent', () => {
  let component: NajlepszyComponent;
  let fixture: ComponentFixture<NajlepszyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NajlepszyComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NajlepszyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
