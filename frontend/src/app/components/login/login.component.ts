import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/models/User';
import { LoginService } from 'src/app/services/login.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
})
export class LoginComponent implements OnInit {
  public user: any;
  userData: User = {
    userId: 0,
    email: '',
    password: '',
  };

  message: string = '';
  textColor: string = 'black';

  constructor(
    private router: Router,
    private userService: UserService,
    private loginService: LoginService
  ) {}

  onFormSubmit(event: any) {
    event.preventDefault();
    this.getUserInfo();
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

  ngOnInit(): void {
    this.message = 'Fill out for logging in.';
    this.textColor = 'black';
  }
}
