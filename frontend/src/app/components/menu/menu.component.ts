import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
})
export class MenuComponent implements OnInit {
  constructor(private router: Router, public user: UserService) {}

  onLogout() {
    this.user.isLoggedIn = false;
    this.router.navigate(['/']);
  }

  ngOnInit(): void {}
}
