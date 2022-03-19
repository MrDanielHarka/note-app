import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/User';
import { UrlService } from './url.service';

@Injectable({
  providedIn: 'root',
})
export class SettingsService {
  constructor(private httpClient: HttpClient, private urlService: UrlService) {}

  public onUpdateSettings(settingsData: User) {
    this.httpClient
      .put(`${this.urlService.serverUrl}/settings`, settingsData, {
        headers: { 'content-type': 'application/json' },
      })
      .subscribe((settingsData) => {
        console.log(settingsData);
        return settingsData;
      });
  }
}
