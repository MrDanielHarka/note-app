import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserNote } from 'src/app/models/UserNote';
import { NoteService } from 'src/app/services/note.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-note',
  templateUrl: './note.component.html',
  styleUrls: ['./note.components.css'],
})
export class NoteComponent implements OnInit {
  public userNotes: any;
  isCreatingNewNote = false;
  isPublic(booleanInteger: number) {
    if (booleanInteger === 1) {
      return 'Make private';
    } else {
      return 'Make public';
    }
  }

  newNote: UserNote = {
    noteId: 0,
    userId: this.userService.userId,
    title: '',
    content: '',
    isPublic: 0,
  };

  updateNote: UserNote = {
    noteId: 0,
    userId: this.userService.userId,
    title: '',
    content: '',
    isPublic: 1,
  };

  constructor(
    public userService: UserService,
    private noteService: NoteService,
    private router: Router
  ) {}

  getUserNotes() {
    this.noteService.onGetUserNotes(this.userService).subscribe((response) => {
      this.userNotes = response;
      // console.log(this.userNotes);
    });
  }

  onFormSubmit(event: any) {
    event.preventDefault();
    this.onNewNote();
  }

  onNewNote() {
    console.log('Note added.');
    this.noteService.onNoteAdded(this.newNote).subscribe((response) => {
      // this.userNotes = response;
    });
    setTimeout(() => {
      this.getUserNotes();
      this.isCreatingNewNote = false;
      this.newNote.title = '';
      this.newNote.content = '';
    }, 500);
  }

  onUpdateNote(noteIndex: number) {
    console.log(noteIndex);
    console.log(this.userNotes);
    console.log(this.userNotes[noteIndex]);
    this.noteService.onUpdateNote(this.userNotes[noteIndex]);
  }

  onToggleSharing(noteIndex: number) {
    if (this.userNotes[noteIndex].public === 1) {
      this.userNotes[noteIndex].public = 0;
    } else {
      this.userNotes[noteIndex].public = 1;
    }
    this.noteService.onUpdateNote(this.userNotes[noteIndex]);
  }

  onDeleteNote(noteIndex: number) {
    this.noteService.onDeleteNote(this.userNotes[noteIndex]);
    // this.getUserNotes();
    setTimeout(() => {
      this.ngOnInit();
    }, 500);
  }

  ngOnInit(): void {
    this.getUserNotes();
    this.isCreatingNewNote = false;
  }
}
