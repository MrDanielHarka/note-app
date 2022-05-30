import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class UrlService {
  serverUrl = 'https://the-note-app.herokuapp.com';

  constructor() {}
}
