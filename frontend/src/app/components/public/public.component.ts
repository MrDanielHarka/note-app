import { Component, OnInit } from '@angular/core';
import { PublicService } from 'src/app/services/public.service';

@Component({
  selector: 'app-public',
  templateUrl: './public.component.html',
})
export class PublicComponent implements OnInit {
  public notes: any;
  constructor(private publicService: PublicService) {}

  getPublicNotes() {
    this.publicService.getPublicNotes().subscribe((response) => {
      this.notes = response;
      console.log(response);
    });
  }

  ngOnInit() {
    this.getPublicNotes();
  }
}
