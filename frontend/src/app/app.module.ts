import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { MenuComponent } from './components/menu/menu.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { PublicComponent } from './components/public/public.component';
import { SettingsComponent } from './components/settings/settings.component';
import { AutoFocusDirective } from './auto-focus.directive';
import { TestComponent } from './components/test/test.component';
import { NoteComponent } from './components/home/note/note.component';
import { WelcomeComponent } from './components/home/welcome/welcome.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    MenuComponent,
    LoginComponent,
    RegisterComponent,
    PublicComponent,
    SettingsComponent,
    AutoFocusDirective,
    TestComponent,
    NoteComponent,
    WelcomeComponent,
  ],
  imports: [BrowserModule, HttpClientModule, AppRoutingModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
