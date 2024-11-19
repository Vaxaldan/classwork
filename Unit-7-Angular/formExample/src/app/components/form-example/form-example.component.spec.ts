import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormExampleComponent } from './form-example.component';

describe('FormExampleComponent', () => {
  let component: FormExampleComponent;
  let fixture: ComponentFixture<FormExampleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FormExampleComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FormExampleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
