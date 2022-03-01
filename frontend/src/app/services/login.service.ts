import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/User';
import { UserService } from './user.service';

@Injectable({
  providedIn: 'root',
})
export class LoginService {
  constructor(
    private httpClient: HttpClient,
    private userService: UserService
  ) {}

  public onLoginUser(userData: User) {
    console.log('User logged in.');

    return this.httpClient.post('http://localhost:5000/login', userData, {
      headers: { 'content-type': 'application/json' },
    });
    // .subscribe((userData) => {
    //   console.log(userData);
    //   return userData;
    // });
  }
}
