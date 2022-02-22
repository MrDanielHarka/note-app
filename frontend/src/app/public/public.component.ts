import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-public',
  templateUrl: './public.component.html',
  styleUrls: ['./public.component.css'],
})
export class PublicComponent implements OnInit {
  public notes!: any;
  constructor(private httpService: HttpService) {}

  getInfo() {
    this.httpService.getPublicNotes().subscribe((response) => {
      this.notes = response.notes;
    });
  }

  ngOnInit() {
    this.getInfo();

    // this.httpService.getPublicNotes().subscribe((response) => {
    //   console.log(response);
    //   this.notes = response;
    // });
  }
}
