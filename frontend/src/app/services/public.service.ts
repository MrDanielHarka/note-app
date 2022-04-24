import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PublicNote } from '../models/PublicNote';
import { UrlService } from './url.service';

@Injectable({
  providedIn: 'root',
})
export class PublicService {
  constructor(private httpClient: HttpClient, private urlService: UrlService) {}

  public getPublicNotes() {
    return this.httpClient.get<PublicNote>(
      `${this.urlService.serverUrl}/public-notes`
    );
  }
}
