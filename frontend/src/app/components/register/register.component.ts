import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  message: string = 'Fill out for registration.';
  isRegistered: boolean = false;

  constructor(private httpClient: HttpClient) {}

  onFormSubmit(event: any) {
    event.preventDefault();
    this.message = 'Awesome! Check your email for confirmation.';
    this.isRegistered = true;
    this.registerUser();
  }

  registerUser() {
    const data = {
      userId: null,
      email: 'daniel@harka.com',
      password: '19930209',
    };
    console.log('User registered.');

    this.httpClient
      .post('http://localhost:5000/register', data, {
        headers: { 'content-type': 'application/json' },
      })
      .subscribe((data) => {
        console.log(data);
      });
  }

  ngOnInit(): void {
    this.registerUser();
  }
}
