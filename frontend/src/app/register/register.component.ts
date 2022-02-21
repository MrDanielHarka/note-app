import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  message: string = 'Fill out for registration.';
  isRegistered: boolean = false;
  constructor() {}

  onFormSubmit(event: any) {
    event.preventDefault();
    this.message = 'Awesome! Check your email for confirmation.';
    this.isRegistered = true;
  }

  ngOnInit(): void {}
}
