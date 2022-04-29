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
  message!: string;
  public userInfo: any;

  userData: User = {
    userId: this.userService.userId,
    firstName: this.userService.firstName,
    lastName: this.userService.lastName,
    email: this.userService.email,
    currentPassword: 'currentPassword',
    newPassword: 'newPassword',
  };

  onSubmit() {
    this.userData.email = this.settingsForm.value.email;
    this.userData.firstName = this.settingsForm.value.firstname;
    this.userData.lastName = this.settingsForm.value.lastname;
    this.userData.currentPassword = this.settingsForm.value.currentPassword;
    this.userData.newPassword = this.settingsForm.value.newPassword;
    this.settingsService
      .onUpdateSettings(this.userData)
      .subscribe((response) => {
        console.log(response);
        this.userInfo = response;
        this.message = this.userInfo.message;
        if (this.userInfo.message === undefined) {
          this.submitted = true;
          this.userService.email = this.settingsForm.value.email;
          this.userService.firstName = this.settingsForm.value.firstname;
          this.userService.lastName = this.settingsForm.value.lastname;
          this.message = 'Settings saved successfully!';
          console.log(this.userService);
        }
      });
  }

  constructor(
    public userService: UserService,
    private settingsService: SettingsService
  ) {}

  ngOnInit(): void {}
}
