import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root',
})
export class LoginService {
  constructor(private httpClient: HttpClient) {}

  public getUserInfo() {
    const something = this.httpClient.get<User>('http://localhost:5000/public');
    return something;
  }
}
