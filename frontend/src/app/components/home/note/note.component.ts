import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { UserNote } from 'src/app/models/UserNote';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-note',
  templateUrl: './note.component.html',
})
export class NoteComponent implements OnInit {
  note: UserNote = {
    userId: this.userService.userId,
    title: '',
    content: '',
    isPublic: 1,
  };
  constructor(
    private httpClient: HttpClient,
    private userService: UserService
  ) {}

  onFormSubmit(event: any) {
    event.preventDefault();
    this.onNoteSave();
  }

  onNoteSave() {
    console.log('Note added.');
    this.httpClient
      .post('http://localhost:5000/', this.note, {
        headers: { 'content-type': 'application/json' },
      })
      .subscribe((note) => {
        console.log(note);
        return note;
      });
  }

  ngOnInit(): void {
    console.log(this.userService.userId);
  }
}
