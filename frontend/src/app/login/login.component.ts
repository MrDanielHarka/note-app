import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  email: string = '';
  password: string = '';
  message: string = '';
  textColor: string = 'black';

  onFormSubmit(event: any) {
    event.preventDefault();
    if (
      this.email === this.user.email &&
      this.password === this.user.password
    ) {
      this.user.isLoggedIn = true;
      this.router.navigate(['/']);
    } else if (this.email !== this.user.email) {
      this.message = 'Invalid email!';
      this.textColor = 'red';
    } else if (this.password !== this.user.password) {
      this.message = 'Invalid password!';
      this.textColor = 'red';
    }
  }

  constructor(private router: Router, private user: UserService) {}

  ngOnInit(): void {
    this.message = 'Fill out for logging in.';
    this.textColor = 'black';
  }
}
