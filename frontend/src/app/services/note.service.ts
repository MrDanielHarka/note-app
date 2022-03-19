import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/User';
import { UserNote } from '../models/UserNote';
import { UrlService } from './url.service';

@Injectable({
  providedIn: 'root',
})
export class NoteService {
  constructor(private httpClient: HttpClient, private urlService: UrlService) {}

  public onGetUserNotes(user: User) {
    return this.httpClient.post(
      `${this.urlService.serverUrl}/user-notes`,
      user,
      {
        headers: { 'content-type': 'application/json' },
      }
    );
  }

  public onNoteAdded(newNote: UserNote) {
    return this.httpClient.post(
      `${this.urlService.serverUrl}/new-note`,
      newNote,
      {
        headers: { 'content-type': 'application/json' },
      }
    );
  }

  public onUpdateNote(updateData: UserNote) {
    this.httpClient
      .put(`${this.urlService.serverUrl}/update-note`, updateData, {
        headers: { 'content-type': 'application/json' },
      })
      .subscribe((updateData) => {
        console.log(updateData);
        return updateData;
      });
  }

  public onDeleteNote(noteId: number) {
    this.httpClient
      .put(`${this.urlService.serverUrl}/delete-note`, noteId, {
        headers: { 'content-type': 'application/json' },
      })
      .subscribe((updateData) => {
        console.log(updateData);
        return updateData;
      });
  }
}
