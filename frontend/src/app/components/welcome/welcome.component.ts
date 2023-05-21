import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { UrlService } from 'src/app/services/url.service';

@Component({
  selector: 'app-welcome',
  templateUrl: './welcome.component.html',
  styleUrls: ['./welcome.component.css'],
})
export class WelcomeComponent implements OnInit {
  public stats: any;

  constructor(private httpClient: HttpClient, private urlService: UrlService) {}

  public getStats() {
    return this.httpClient.get<any>(`${this.urlService.serverUrl}/stats`);
  }

  getPublicStats() {
    this.getStats().subscribe((response) => {
      this.stats = response;
    });
  }

  ngOnInit() {
    this.getPublicStats();
  }
}
