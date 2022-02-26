import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PublicNote } from '../models/PublicNote';

@Injectable({
  providedIn: 'root',
})
export class PublicService {
  constructor(private httpClient: HttpClient) {}

  public getPublicNotes() {
    const something = this.httpClient.get<PublicNote>(
      'http://localhost:5000/public'
    );
    return something;
  }
}
