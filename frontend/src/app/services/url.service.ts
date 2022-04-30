import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class UrlService {
  serverUrl = 'http://localhost:5000';
  // serverUrl = '.';
  // serverUrl = 'https://the-note-app.herokuapp.com';

  constructor() {}
}
