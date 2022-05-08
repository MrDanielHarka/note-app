import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/User';
import { UrlService } from './url.service';

@Injectable({
  providedIn: 'root',
})
export class RegisterService {
  constructor(private httpClient: HttpClient, private urlService: UrlService) {}

  public onRegisterUser(userData: User) {
    return this.httpClient.post(
      `${this.urlService.serverUrl}/register`,
      userData,
      {
        headers: { 'content-type': 'application/json' },
      }
    );
  }
}
