import { Component } from '@angular/core';
import { HttpService } from './http.service';
import { UserService } from './user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  constructor(private httpService: HttpService, public user: UserService) {}

  onTerm(term: string) {
    this.httpService.getPublicNotes(term).subscribe((response) => {
      console.log(response);
    });
  }
}
