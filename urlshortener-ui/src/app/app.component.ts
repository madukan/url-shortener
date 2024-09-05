import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { addIcons } from "ionicons";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'urlshortener-ui';
}

@Component({
  selector: 'input-full-url',
  standalone: true,
  template: '<input type=text/>',
  styleUrl: './app.component.css'
})

export class InputFullUrl {
  title = 'input-full-url';
}

