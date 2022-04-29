# Note App - Documentation <a id="top"></a>

This is the documentation of the Note App.

## Table of contents

- [What is this?](#what-is-this)
  - [Introduction](#introduction)
  - [Tech stack](#tech-stack)
- [Who created it?](#who-created)
- [What are the features?](#features)
- [How to use it?](#how-to-use)
  - [Using the web app](#using-web-app)
  - [Using the desktop app](#using-desktop-app)
- [How to build/deploy/test it?](#building)
  - [Web app source](#web-source)
  - [Desktop app source](#desktop-source)
- [How was it developed?](#how-developed)
  - [Brainstorming](#brainstorming)
  - [Wireframe](#wireframe)
  - [Git(Hub)](#git)
  - [Database](#database)
  - [Frontend](#frontend)
  - [Backend](#backend)
  - [Desktop](#desktop)
- [How was it tested?](#testing)

  - [Web app testing](#web-testing)
  - [Desktop app testing](#desktop-testing)
- [What are the limitations?](#limitations)
- [Which are the future plans?](#future-plans)
- [How to collaborate?](#collaboration)
- [Why was it needed?](#why-needed)
- [Where was it created?](#where-created)
- [When was it developed?](#when-developed)
- [Who helped?](#who-helped)
- [What were the resources?](#resources)

## What is this? <a id="what-is-this"></a>

Here is some basic, TLDR information about the project.

Random labels: Rest API, CRUD app, HTTP, JavaScript, TypeScript, Angular, requests, promises, observable, responsive, Cypress, C#

### Introduction <a id="introduction"></a>

This is simple and minimalistic note taking app, for developers, recruiters, teachers, couriers and basically anybody, who would like to take quick notes.

### Tech stack <a id="tech-stack"></a>

**Database**

For the database a MySQL database of the MariaDB type is used, which is running on phpMyAdmin.

**Frontend**

For the frontend the Angular framework is used. It's a development platform, which is built on TypeScript.

**Backend**

For the backend Node.js is used, which is a JavaScript runtime built on Chrome's V8 JavaScript engine.

**Desktop**

For the Desktop C# is used. It's an object-oriented and type-safe programming language.

[Top ↑](#top)

## Who created it? <a id="who-created"></a>

These are the developers and maintainers of the project:

- Jozsef Biro ([https://github.com/bjozsef02](https://github.com/bjozsef02))
- Daniel Harka ([https://github.com/MrDanielHarka](https://github.com/MrDanielHarka))

[Top ↑](#top)

## What are the features? <a id="features"></a>

Anybody, even unregistered users can see the public notes which are taken by registered users. When a user logs in then they have the opportunity to take notes of their own. They can also change or delete their notes later on if they wish to. Notes can be toggled to public, so those can be read by anybody who are using the app. Users are also able to change their settings in the applications.

Moreover, in the desktop application, users can share their notes to specific people, by providing an email address. If the admins log in, they can also perform the aforementioned functions, in addition to seeing various statistics about users, without violating their private data.

[Top ↑](#top)

## How to use it? <a id="how-to-use"></a>

### Using the web app <a id="using-web-app"></a>

**Usage**

**Hardware & software requirements**

### Using the desktop app <a id="using-desktop-app"></a>

**Usage**

The user must log in first or register if they are not already registered. The password is encrypted in the database during registration. Password encryption works “back and forth” between the web application and the desktop. After logging in your can check your notes, the publical notes and the shared notes which you get from other people. All these three categories of notes will apper in three different tables.

Your own notes table have a four buttons column the first button is tell yout is it publical or not. If it is not a publical note the button text is private if it is publical the button text is publical, if the button text is publical and you press it you can make it private, if it is private and you press it you can make it publical.

The second button is the share button, the share button text private if it is not a shared note, if the button text is shared the note is shared with atleast one person.If the button text is private and you press it you can share it if you know his email address , if the button text is shared you still can share with some else buti f you want you also can make it private. It is also possible to unshare a note with someone.

The third button is the save as button with this button you can save your note in your pc or laptop.

The fourth button is the delete button with this button you can delete your note.

**Operating System**

Windows 10 or later.

**Hardware requirements**

1.8 GHz or faster processor

Minimum 2 GB RAM

Hard disk space: at least 800 MB

A video card that supports a minimum display resolution of 720p (1280 x 720).

**Hardware & software requirements**

[Top ↑](#top)

## How to build/deploy/test it? <a id="building"></a>

### Web app source <a id="web-source"></a>

The source code can be either forked, cloned or downloaded as a zip file.

The frontend part can be run with `ng serve` if the Angular CLI is present on the system.

The backend part can be run with `node app.js`, `nodemon app.js` or `heroku local web`.

A database needs to be connected to the app in order for it to work properly. It can be a local one, but it can also be on an online server.

### Desktop app source <a id="desktop-source"></a>

The application's source can be downloaded from GitHub, then the testing can begin right away. A working database is also needed, to be able to test the app locally.

[Top ↑](#top)

## How was it developed? <a id="how-developed"></a>

Here is how the applications function:

Here is how it was made:

### Brainstorming

It was a completely random idea. A project was needed and since Jozsef and Daniel did not have any specific ideas, they just picked a topic which they thought they could learn the most from. Hence the choice was a note taking app, which is somewhat similar to Google Keep, but simpler and more minimalistic.

The idea was that users can save notes after logging in. They can of course edit them. When that's done, then they wanted users to be able to make the notes public, so everybody can see them. After all that is done and there is still time left, then they wanted to enable users to share notes between eachother.

### Wireframe

Sorry, the initial wireframes were made in Hungarian, but hopefully you get the idea. This was just a quick example how the app might look like.

**[Desktop Wireframe]**

**[Mobile Wireframe]**

[Top ↑](#top)

### Git(Hub) <a id="git"></a>

Something was needed for collaboration and version control. Git was the obvious best choice to start with, because it is perfect for both use cases. Jozsef and Daniel wanted to learn and use a tool, which will be useful for them in the future as well, when they are working as developers.

They also needed a platform where they could publish their work using Git. Bitbucket and GitLab were also considered, but they went for GitHub in the end, for it being the most used and most documentation is available for that platform.

Then the Note App repository was born and they have collaborated in that, since the very beginning of the project. Jozsef and Daniel both did the coding on their own computers. The code was committed and uploaded to GitHub regularly using Git, after changes were made to the source.

[Top ↑](#top)

### Database

The data of the web and desktop app needed to be stored somewhere, so a database was needed.

After spending way to much time on searching for a free database provider, finally the ClearDB service was found. It offers 5MBs of free storage for Heroku users.

Jozsef worked mostly on this part, but got help from Daniel.

[Top ↑](#top)

### Frontend

The frontend of the web app could be made with HTML5, CSS3 and vanilla JavaScript, but to be able to create something that is complex and can be scaled later on, Angular was chosen.

Coding in Angular is by using TypeScript, which is a superset of JavaScript. It helps developers by letting them assign types to variables and there is also strict error checking, so there would be less errors during runtime and errors are caught on compilation.

Angular applications are built with components and this complex app is also built by quite a few of them. You can have an insight of the folder and file structure on the image below.

```
app/
├─ components/
│  ├─ home/
│  ├─ login/
│  ├─ menu/
│  ├─ note/
│  ├─ public/
│  ├─ register/
│  ├─ settings/
│  ├─ welcome/
│  │  ├─ welcome.component.css
│  │  ├─ welcome.component.html
│  │  ├─ welcome.component.ts
```

Components are TypeScript classes which determine, how that specific part or building block of the application will behave and function. View (HTML) and style (CSS) can also be assigned to components either inline or externally. Those determine the structure and customization of the components.

Let's take a look at the **note component**, to get some basic understanding of how components work.

```typescript
// These are the imports that are needed for the service to work properly.

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserNote } from 'src/app/models/UserNote';
import { NoteService } from 'src/app/services/note.service';
import { UserService } from 'src/app/services/user.service';

// These are the component details.

@Component({
  selector: 'app-note', // This is how the component is accessed.
  templateUrl: './note.component.html', // This is the component's view.
  styleUrls: ['./note.components.css'], // This is the component's style. 
})

// This part determined the logic of the component.

export class NoteComponent implements OnInit {
  public userNotes: any;
  isCreatingNewNote = false;
  isPublic(booleanInteger: number) {
    if (booleanInteger === 1) {
      return 'Make private';
    } else {
      return 'Make public';
    }
  }

// This is the structure of a new note.    
    
  newNote: UserNote = {
    noteId: 0,
    userId: this.userService.userId,
    title: '',
    content: '',
    isPublic: 0,
  };
    
// This is the structure of an updated note.

  updateNote: UserNote = {
    noteId: 0,
    userId: this.userService.userId,
    title: '',
    content: '',
    isPublic: 1,
  };
    
// The used dependencies are put in the constructor, so no instantiation is needed and our component can use the services.

  constructor(
    public userService: UserService,
    private noteService: NoteService,
    private router: Router
  ) {}
    
// This part is needed to get the user notes from the backend.

  getUserNotes() {
    this.noteService.onGetUserNotes(this.userService).subscribe((response) => {
      this.userNotes = response;
      // console.log(this.userNotes);
    });
  }
    
// This code runs, when a new note is created.

  onFormSubmit(event: any) {
    event.preventDefault();
    this.onNewNote();
  }

  onNewNote() {
    console.log('Note added.');
    this.noteService.onNoteAdded(this.newNote).subscribe((response) => {
      // this.userNotes = response;
    });
    setTimeout(() => {
      this.newNote.title = '';
      this.newNote.content = '';
      this.getUserNotes();
      this.isCreatingNewNote = false;
    }, 500);
  }
    
 // This code runs, when a note is edited.

  onUpdateNote(noteIndex: number) {
    console.log(noteIndex);
    console.log(this.userNotes);
    console.log(this.userNotes[noteIndex]);
    this.noteService.onUpdateNote(this.userNotes[noteIndex]);
  }
    
 // This code runs, when the note's public status is toggled.

  onToggleSharing(noteIndex: number) {
    if (this.userNotes[noteIndex].public === 1) {
      this.userNotes[noteIndex].public = 0;
    } else {
      this.userNotes[noteIndex].public = 1;
    }
    this.noteService.onUpdateNote(this.userNotes[noteIndex]);
  }
    
// This code runs, when a note is deleted.
    
  onDeleteNote(noteIndex: number) {
    this.noteService.onDeleteNote(this.userNotes[noteIndex]);
    // this.getUserNotes();
    setTimeout(() => {
      this.ngOnInit();
    }, 500);
  }

// This code runs once, when our component loads.
    
  ngOnInit(): void {
    this.getUserNotes();
    this.isCreatingNewNote = false;
  }
}

```

Services are special type of components, that are widely available within the application and are accessible by all of the components. Those usually contain shared information and logic, that multiple components need and rely on to be able to function correctly.

The following are the ones used in this application:

```
services/
├─ login.service.ts
├─ note.service.ts
├─ public.service.ts
├─ settings.service.ts
├─ url.service.ts
├─ user.service.ts
```

Let's take a look at the **note service**, to get some basic understanding of how services work.

```typescript
// These are the imports that are needed for the service to work properly.

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/User';
import { UserNote } from '../models/UserNote';
import { UrlService } from './url.service';

// We declare it an injectable, which means other parts of the app can use it.
@Injectable({
  providedIn: 'root',
})

// The class is exported, so other components can use it.

export class NoteService {
  constructor(private httpClient: HttpClient, private urlService: UrlService) {}

 // This part gets the user notes, that are already in the database.
    
  public onGetUserNotes(user: User) {
    return this.httpClient.post(
      `${this.urlService.serverUrl}/user-notes`,
      user,
      {
        headers: { 'content-type': 'application/json' },
      }
    );
  }

 // This code runs when a new note is added.
    
  public onNoteAdded(newNote: UserNote) {
    return this.httpClient.post(
      `${this.urlService.serverUrl}/new-note`,
      newNote,
      {
        headers: { 'content-type': 'application/json' },
      }
    );
  }
    
// This is needed for when a note is updated by a user.
    
  public onUpdateNote(updateData: UserNote) {
    this.httpClient
      .put(`${this.urlService.serverUrl}/update-note`, updateData, {
        headers: { 'content-type': 'application/json' },
      })
      .subscribe((updateData) => {
        console.log(updateData);
        return updateData;
      });
  }
    
 // This one runs, when a note is deleted.

  public onDeleteNote(noteId: number) {
    this.httpClient
      .put(`${this.urlService.serverUrl}/delete-note`, noteId, {
        headers: { 'content-type': 'application/json' },
      })
      .subscribe((updateData) => {
        console.log(updateData);
        return updateData;
      });
  }
}
```

The components can communicate with the backend through services and that is how a full stack application can be achieved.

The styling and design of the web app could have been a downloadable, ready-made template. Instead of that, it was created using Angular Material Design completely from scratch, which was far from an easy task. Quite a few material design modules needed to be imported to the code and it's syntax is super opinionated, which makes it pretty difficult to style even the most uncomplicated elements. Below is an example of a simple password input field, which is not so simple with Angular Material.

```html
<mat-form-field class="card-full-width">
    <mat-label>Password</mat-label>
    <br />
    <input
           type="password"
           name="password"
           id="password"
           ngModel
           #password
           matInput
           password
           required
           minlength="6"
           />
    <mat-hint>Enter password</mat-hint>
    <mat-error>It must be over 5 characters</mat-error>
</mat-form-field>
```

Daniel carried out this part.

[Top ↑](#top)

### Backend

The backend of the application could be made with TypeScript, just like the frontend, but as most of the tutorials, lessons and walkthroughs are written in plain JavaScript, that's why it was written in vanilla JavaScript. It may be rewritten in TypeScript in the future.

However, some Node packages were needed as it would be quite complicated to code all this without them. Hence the Express backend framework and the MySQL, Bcrypt, CORS, Nodemon packages were used. Those can be installed all at once like this:

```bash
npm install express mysql bcrypt cors nodemon
```

Express makes receiving HTTP requests somewhat easier than doing it in plain JavaScript. It has built in tools and methods, to make these processes quicker and simpler.

The MySQL package makes it possible to communicate with the database. Connecting to the database is pretty similar to using PHP. Below is an example where connecting to a local database can be seen:

```javascript
// Initializing MySQL module
const mysql = require('mysql');

// Setting connection details
const con = mysql.createConnection({
  host: 'localhost',
  user: 'root',
  password: '',
  database: 'note_app',
});

// Connecting to database
con.connect(function (err) {
  if (err) throw err;
  console.log('Connected to database.');
});
```

The CORS package is needed, so the frontend would be able to connect to the backend. Code that are located on different servers and/or run on different ports are not able to communicate with eachother as a security measure, so that no unauthorised access would be made. It can be specified with this module from which server(s) are connections allowed. In the below example the \' \* ' wildcard (or "catch all") symbol is used, which means connection is allowed from any server or port. Using this exact setup is generally not a good idea, as it might be a security issue, but since the application is still in beta and connections are made from different servers for testing purposes, that's why this was used.

```javascript
// Initializing CORS module
const cors = require('cors');

// Wildcard server acceptance
const corsOptions = {
  origin: '*',
};
```

In the following code snippet the cooperation of the Express framework and the Bcrypt module can be seen:

```javascript
app.post('/register', async (req, res) => {
  firstName = req.body.firstName;
  lastName = req.body.lastName;
  email = req.body.email;
  password = req.body.password;
  hash = await bcrypt.hash(password, saltRounds);
  query = `INSERT INTO users (id, email, password, first_name, last_name)
  VALUES (null, '${email}', '${hash}', '${firstName}', '${lastName}')`;

  pool.query(query, (err) => {
    if (err) {
      if (err.code == 'ER_DUP_ENTRY' || err.errno == 1062) {
        res.status(200).send(`{
            "message": "This email address is already registered."
          }`);
      } else {
        console.log('Other error in the query');
        console.log(err);
      }
    } else {
      res.status(200).send(`{
            "success": "Success! You can now log in."
          }`);
    }
  });
});
```



The Nodemon package was also super useful. A node server needs to be stopped every single time a code change has been made and needs to be started again, so that the changes would be reflected on the app. Nodemon solves this useless waste of time by automatically restarting the backend every single time the document is saved. It can be imagined as an HTML 'live server' or Angular's 'ng serve', but for the Node.js backend.

Daniel worked mostly on this part, but got help from Jozsef. NodeJS. Express. Cors. Json. Nodemon.

[Top ↑](#top)

### Desktop

xampp

It had to be used because of the database.

Visual Studio 2019

The programming language is c #.

Used temple Windows Forms App (.NET Framework)

Used usings: using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using MySql.Data.MySqlClient;

using System.IO;

Jozsef carried out this part. Lalalaaaa.

## How was it tested? <a id="testing"></a>

### Web app testing <a id="web-testing"></a>

### Desktop app testing <a id="desktop-testing"></a>

[Top ↑](#top)

## What are the limitations? <a id="limitations"></a>

## Which are the future plans? <a id="future-plans"></a>

World domination of course, khm... on a more serious note:

- cookies, localstorage, sessionstorage
- GitHub, Google, Facebook login possibility
- email intergration for registration and forgotten passwords
- dark mode
- language selector
- public note content search
- note character count
- secure password check upon registration
- download txt
- upload txt
- rewrite backend in TypeScript
- user profile picture
- note categories
- filter personal and public notes by category

[Top ↑](#top)



## How to collaborate? <a id="collaboration"></a>

This repository can be forked on GitHub, cloned to anyone's computer, then after corrections, fixes or changes are made a pull request can be sent to the developers. The code would be checked and if it's indeed useful, then the pull request is accepted and the changes are published in the web or desktop app.

[Top ↑](#top)

## Why was it needed? <a id="why-needed"></a>

Jozsef and Daniel started an adult course and to be able to fulfill all the requirements of it, they needed to deliver a responsive, fullstack app with an optional desktop app, hence these apps were born.

[Top ↑](#top)

## Where was it created? <a id="where-created"></a>

Made with <3 in Budapest, Hungary.

[Top ↑](#top)

## When was is it developed? <a id="when-developed"></a>

It was worked on between January and May of 2022.

[Top ↑](#top)

## Who helped? <name id="who-helped"></a>

Special thanks to Róbertné Csilla Dobrocsi, István Bencze, Csaba Kecskeméti and Ifj. István Bencze for their support.

[Top ↑](#top)

## What are the sources? <a id="sources"></a>

**Software**

Visual Studio Code, Visual Studio 2019 Community, XAMPP, phpMyAdmin, Vivaldi Browser, Google Chrome, Git, GitHub, Microsoft Teams, DIscord, Facebook/Messenger.

**Literature**

Tools used:

Apps used:

Literature used:

C#, Node.js, Angular, angular.io, nodemon, ng-book, angular material, Postman, Cypress, Heroku, ClearDB,

Code sources:

[Top ↑](#top)
