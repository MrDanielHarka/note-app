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

  public user: any;

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
    console.log(this.loginForm.value.email);
    console.log(this.loginForm.value.password);
    this.userData.email = this.loginForm.value.email;
    this.userData.password = this.loginForm.value.password;
    this.getUserInfo();
    // this.loginForm.reset();
  }

  getUserInfo() {
    this.loginService.onLoginUser(this.userData).subscribe((response) => {
      this.user = response;
      if (
        this.userData.email === this.user.email &&
        this.userData.password === this.user.password
      ) {
        this.userService.userId = this.user.id;
        this.userService.email = this.user.email;
        this.userService.password = this.user.password;
        this.userService.firstName = this.user.first_name;
        this.userService.lastName = this.user.last_name;
        this.userService.username = this.user.username;
        this.router.navigate(['/']);
        this.userService.isLoggedIn = true
          ? this.user.email === this.userData.email
          : false;
      } else if (
        this.userData.email === this.user.email &&
        this.userData.password !== this.user.password
      ) {
        console.log('Wrong password!');
      }
    });
  }

  ngOnInit(): void {}
}
