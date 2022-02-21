import { Component, OnInit } from '@angular/core';
import { UserService } from '../user.service';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html',
  styleUrls: ['./settings.component.css'],
})
export class SettingsComponent implements OnInit {
  email: string = '';
  password: string = '';
  newPassword: string = '';
  message: string = '';
  textColor: string = 'black';

  onFormSubmit(event: any) {
    event.preventDefault();
  }

  constructor(public user: UserService) {}

  ngOnInit(): void {}
}
