import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class UrlService {
  serverUrl = 'http://localhost:5000';
  // serverUrl = 'https://us-central1-the-simple-notes.cloudfunctions.net/app';
  constructor() {}
}
