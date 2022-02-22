import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

export interface PublicNote {
  notes: { id: number; title: string; content: string }[];
}

@Injectable({
  providedIn: 'root',
})
export class HttpService {
  constructor(private http: HttpClient) {}

  public getPublicNotes(term?: string) {
    const something = this.http.get<PublicNote>('http://localhost:5000');
    return something;
  }
}
