import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  email: string = '';
  password: string = '';
  userId?: number;
  isLoggedIn: boolean = false;

  constructor() {}
}
