import { Component, OnInit } from '@angular/core';
import { PublicService } from 'src/app/services/public.service';

@Component({
  selector: 'app-public',
  templateUrl: './public.component.html',
})
export class PublicComponent implements OnInit {
  public publicNotes: any;
  constructor(private publicService: PublicService) {}

  getPublicNotes() {
    this.publicService.getPublicNotes().subscribe((response) => {
      this.publicNotes = response;
    });
  }

  ngOnInit() {
    this.getPublicNotes();
  }
}
