import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UserNote } from '../models/UserNote';

@Injectable({
  providedIn: 'root',
})
export class NoteService {
  constructor(private httpClient: HttpClient) {}

  public getUserNotes() {
    return this.httpClient.get<UserNote>('http://localhost:5000/');
  }
}
