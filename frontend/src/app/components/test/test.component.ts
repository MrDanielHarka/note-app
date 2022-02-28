import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
})
export class TestComponent implements OnInit {
  url: string = 'http://localhost:5000';

  constructor(private httpClient: HttpClient) {}

  ngOnInit(): void {}
}
