import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/User';
import { UrlService } from './url.service';

@Injectable({
  providedIn: 'root',
})
export class LoginService {
  constructor(private httpClient: HttpClient, private urlService: UrlService) {}

  public onLoginUser(userData: User) {
    return this.httpClient.post(
      `${this.urlService.serverUrl}/login`,
      userData,
      {
        headers: { 'content-type': 'application/json' },
      }
    );
  }
}
