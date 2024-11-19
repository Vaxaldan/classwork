import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'form-example',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './form-example.component.html',
  styleUrl: './form-example.component.css'
})
export class FormExampleComponent {
onSubmit() {
console.log('Ok... You clicked Submit')
}

}
