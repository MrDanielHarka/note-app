import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { UserNote } from 'src/app/models/UserNote';
import { NoteService } from 'src/app/services/note.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-note',
  templateUrl: './note.component.html',
})
export class NoteComponent implements OnInit {
  userNote: UserNote = {
    noteId: 0,
    userId: this.userService.userId,
    title: '',
    content: '',
    isPublic: 1,
  };

  public userNotes: any;

  constructor(
    private httpClient: HttpClient,
    private userService: UserService,
    private noteService: NoteService
  ) {}

  onFormSubmit(event: any) {
    event.preventDefault();
    this.onNoteSave();
  }

  onNoteSave() {
    console.log('Note added.');
    this.httpClient
      .post('http://localhost:5000/', this.userNote, {
        headers: { 'content-type': 'application/json' },
      })
      // Note does not get sent to backend without below code
      .subscribe((note) => {
        console.log(note);
        return note;
      });
  }

  getUserNotes() {
    this.noteService.getUserNotes().subscribe((response) => {
      this.userNotes = response;
      console.log(response);
      console.log(this.userNotes);
    });
  }

  ngOnInit(): void {
    this.getUserNotes();
  }
}
