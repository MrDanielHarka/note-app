import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
})
export class LoginComponent implements OnInit {
  email: string = '';
  password: string = '';
  message: string = '';
  textColor: string = 'black';

  constructor(private router: Router, private userService: UserService) {}

  onFormSubmit(event: any) {
    event.preventDefault();
    if (
      this.email === this.userService.email &&
      this.password === this.userService.password
    ) {
      this.userService.isLoggedIn = true;
      this.router.navigate(['/']);
    } else if (this.email !== this.userService.email) {
      this.message = 'Invalid email!';
      this.textColor = 'red';
    } else if (this.password !== this.userService.password) {
      this.message = 'Invalid password!';
      this.textColor = 'red';
    }
  }

  getUserInfo() {
    this.userService.getUserInfo().subscribe((response) => {
      console.log(response);
    });
  }

  ngOnInit(): void {
    this.message = 'Fill out for logging in.';
    this.textColor = 'black';
  }
}
