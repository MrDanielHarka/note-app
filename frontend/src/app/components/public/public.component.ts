import { Component, OnInit } from '@angular/core';
import { PublicService } from 'src/app/services/public.service';

@Component({
  selector: 'app-public',
  templateUrl: './public.component.html',
  styleUrls: ['./public.component.css'],
})
export class PublicComponent implements OnInit {
  public notes!: any;
  constructor(private publicService: PublicService) {}

  getInfo() {
    this.publicService.getPublicNotes().subscribe((response) => {
      this.notes = response.notes;
    });
  }

  ngOnInit() {
    this.getInfo();
  }
}
