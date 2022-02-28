import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/User';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
})
export class RegisterComponent implements OnInit {
  message = 'Fill out for registration.';
  isRegistered = false;

  data: User = {
    email: '',
    password: '',
  };

  constructor(private httpClient: HttpClient) {}

  onFormSubmit(event: any) {
    event.preventDefault();
    this.message = 'Awesome! Check your email for confirmation.';
    this.isRegistered = true;
    this.registerUser();
  }

  registerUser() {
    console.log('User registered.');

    this.httpClient
      .post('http://localhost:5000/register', this.data, {
        headers: { 'content-type': 'application/json' },
      })
      .subscribe((data) => {
        console.log(data);
        return data;
      });
  }

  ngOnInit(): void {
    // this.registerUser();
  }
}

// post w/o subscribe
// type inferring
// clean code
// js videók
