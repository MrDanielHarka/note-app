import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-public',
  templateUrl: './public.component.html',
  styleUrls: ['./public.component.css'],
})
export class PublicComponent implements OnInit {
  notes: any;
  constructor(private http: HttpClient, private httpService: HttpService) {}

  getInfo() {
    this.httpService.getPublicNotes().subscribe((response) => {
      console.log(response);
    });
  }

  ngOnInit() {
    // this.httpService.getPublicNotes().subscribe((response) => {
    //   console.log(response);
    //   this.notes = response;
    // });
  }
}
