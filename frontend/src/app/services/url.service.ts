import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class UrlService {
  serverUrl = 'http://localhost:5000';

  constructor() {}
}
