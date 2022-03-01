import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root',
})
export class RegisterService {
  constructor(private httpClient: HttpClient) {}

  public onRegisterUser(userData: User) {
    console.log('User registered.');

    this.httpClient
      .post('http://localhost:5000/register', userData, {
        headers: { 'content-type': 'application/json' },
      })
      .subscribe((userData) => {
        console.log(userData);
        return userData;
      });
  }
}
