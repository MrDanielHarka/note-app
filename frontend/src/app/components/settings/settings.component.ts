import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { User } from 'src/app/models/User';
import { SettingsService } from 'src/app/services/settings.service';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html',
})
export class SettingsComponent implements OnInit {
  @ViewChild('form') settingsForm!: NgForm;
  submitted = false;
  myValue = 'hali';

  userData: User = {
    userId: this.userService.userId,
    firstName: this.userService.firstName,
    lastName: this.userService.lastName,
    email: this.userService.email,
    password: this.userService.password,
  };

  onSubmit() {
    if (this.settingsForm.value.currentPassword === this.userService.password) {
      this.userData.firstName = this.settingsForm.value.firstname;
      this.userService.firstName = this.settingsForm.value.firstname;
      this.userData.lastName = this.settingsForm.value.lastname;
      this.userService.lastName = this.settingsForm.value.lastname;
      this.userData.email = this.settingsForm.value.email;
      this.userService.email = this.settingsForm.value.email;
      if (this.settingsForm.value.newPassword !== '') {
        this.userData.password = this.settingsForm.value.newPassword;
        this.userService.password = this.settingsForm.value.newPassword;
      }
      this.settingsService.onUpdateSettings(this.userData);

      // this.settingsForm.reset();
    } else {
      console.log('Wrong password.');
    }
    console.log(this.userData);
    console.log(this.userService);
  }

  constructor(
    public userService: UserService,
    private settingsService: SettingsService
  ) {}

  ngOnInit(): void {}
}
