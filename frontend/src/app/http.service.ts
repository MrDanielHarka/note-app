import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class HttpService {
  constructor(private http: HttpClient) {}

  public getPublicNotes(term?: string) {
    const something = this.http.get('http://localhost:5000');
    console.log(something);
    return something;
  }
}
