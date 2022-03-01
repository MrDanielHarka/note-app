import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  userId: number = 0;
  email: string = '';
  password: string = '';
  firstName: string = '';
  lastName: string = '';
  username: string = '';
  isLoggedIn: boolean = false;

  constructor() {}
}
