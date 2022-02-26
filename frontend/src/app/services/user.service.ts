import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  email: string = 'daniel@harka.com';
  password: string = '19930209';
  isLoggedIn: boolean = false;

  constructor() {}
}
