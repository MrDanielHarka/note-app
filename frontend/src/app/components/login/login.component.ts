import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { User } from 'src/app/models/User';
import { LoginService } from 'src/app/services/login.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  @ViewChild('form') loginForm!: NgForm;
  submitted = false;
  message!: string;

  public userInfo: any;

  userData: User = {
    email: '',
    password: '',
  };

  constructor(
    private userService: UserService,
    private loginService: LoginService,
    private router: Router
  ) {}

  onSubmit() {
    this.submitted = true;
    this.userData.email = this.loginForm.value.email;
    this.userData.password = this.loginForm.value.password;
    this.getUserInfo();
  }

  getUserInfo() {
    this.loginService.onLoginUser(this.userData).subscribe((response) => {
      this.userInfo = response;
      this.message = this.userInfo.message;
      this.userService.userId = this.userInfo.userId;
      this.userService.email = this.userInfo.email;
      this.userService.firstName = this.userInfo.firstName;
      this.userService.lastName = this.userInfo.lastName;
      this.userService.isLoggedIn = this.userInfo.isLoggedIn;
      if (this.userService.isLoggedIn) {
        this.router.navigate(['/']);
      }
    });
  }

  ngOnInit(): void {}
}
