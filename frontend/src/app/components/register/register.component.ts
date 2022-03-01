import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/User';
import { RegisterService } from 'src/app/services/register.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
})
export class RegisterComponent implements OnInit {
  message = 'Fill out for registration.';
  isRegistered = false;

  userData: User = {
    userId: 0,
    email: '',
    password: '',
  };

  constructor(private registerService: RegisterService) {}

  onFormSubmit(event: any) {
    event.preventDefault();
    this.message = 'Awesome! Check your email for confirmation.';
    this.isRegistered = true;
    this.registerService.onRegisterUser(this.userData);
  }

  ngOnInit(): void {}
}

// post w/o subscribe
// type inferring
// clean code
// js videók
