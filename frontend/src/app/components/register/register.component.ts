import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { User } from 'src/app/models/User';
import { RegisterService } from 'src/app/services/register.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
})
export class RegisterComponent implements OnInit {
  @ViewChild('form') registerForm!: NgForm;
  submitted = false;
  message!: string;

  public userInfo: any;

  userData: User = {
    firstName: '',
    lastName: '',
    email: '',
    password: '',
  };

  constructor(private registerService: RegisterService) {}

  onSubmit() {
    this.userInfo = '';
    this.userData.firstName = this.registerForm.value.firstname;
    this.userData.lastName = this.registerForm.value.lastname;
    this.userData.email = this.registerForm.value.email;
    this.userData.password = this.registerForm.value.password;
    this.registerService.onRegisterUser(this.userData).subscribe((response) => {
      this.userInfo = response;
      this.message = this.userInfo.message;
      if (this.userInfo.message === undefined) {
        this.submitted = true;
        this.message = this.userInfo.message;
      }
    });
  }

  ngOnInit(): void {}
}
