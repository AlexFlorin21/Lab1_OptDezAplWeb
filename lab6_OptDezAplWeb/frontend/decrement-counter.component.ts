import { Component } from '@angular/core';

@Component({
  selector: 'app-decrement-counter',
  templateUrl: './decrement-counter.component.html',
  styleUrls: ['./decrement-counter.component.css']
})
export class DecrementCounterComponent {
  counterValue = 0;

  decrementCounter() {
    this.counterValue--;
  }
}
