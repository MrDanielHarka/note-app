import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../../services/user.service';

import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css'],
})
export class MenuComponent implements OnInit {
  isHandset$: Observable<boolean> = this.breakpointObserver
    .observe(Breakpoints.Handset)
    .pipe(
      map((result) => result.matches),
      shareReplay()
    );

  constructor(
    private router: Router,
    public user: UserService,
    private breakpointObserver: BreakpointObserver
  ) {}

  onLogout() {
    this.user.userId = 0;
    this.user.email = '';
    this.user.firstName = '';
    this.user.lastName = '';
    this.user.isLoggedIn = false;
    this.router.navigate(['/']);
  }

  ngOnInit(): void {}
}
