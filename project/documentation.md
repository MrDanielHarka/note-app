# Note App - Documentation <a id="top"></a>

This is the documentation of the Note App.

## Table of contents

- [What is this?](#what-is-this)
  - [Introduction](#introduction)
  - [Tech stack](#tech-stack)
- [Who created it?](#who-created)
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
  - [Resources](#resources)
- [How was it tested?](#testing)

  - [Web app testing](#web-testing)
  - [Desktop app testing](#desktop-testing)

- [What are the limitations?](#limitations)
- [Which are the future plans?](#future-plans)
- [Why was it needed?](#why-needed)
- [Where was it created?](#where-created)
- [When was it developed?](#when-developed)
- [Who helped?](#who-helped)
- [What are the sources?](#sources)

## What is this? <a id="what-is-this"></a>

Here is some basic, TLDR information about the project.

Random labels: Rest API, CRUD app, HTTP, JavaScript, RypeScript, Angular, requests, promises, observable, responsive, Cypress

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

## How to use it? <a id="how-to-use"></a>

### Using the web app <a id="using-web-app"></a>

**Usage**

**Hardware & software requirements**

### Using the desktop app <a id="using-desktop-app"></a>

**Usage**

**Hardware & software requirements**

[Top ↑](#top)

## How to build/deploy/test it? <a id="building"></a>

### Web app source <a id="web-source"></a>

**Blabla**

Install dependencies.

**Hardware & software requirements**

### Desktop app source <a id="desktop-source"></a>

**Hardware & software requirements**

**Blabla**

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

Jozsef worked mostly on this part, but got help from Daniel.

[Top ↑](#top)

### Frontend

The frontend of the web app could be made with HTML5, CSS3 and vanilla JavaScript, but to be able to create something that is complex and can be scaled later on, Angular was chosen.

Coding in Angular is by using TypeScript, which is a superset of JavaScript. It helps developers by letting them assign types to variables and there is also strict error checking, so there would be less errors during runtime and errors are caught on compilation.

Angular applications are built with components and this complex app is also built by quite a few of them. You can have an insight of the folder and file structure on the image below.

[Angular component folder structure image]

Components are TypeScript classes which determine, how that specific part or building block of the application will behave and function. View (HTML) and style (CSS) can also be assigned to components either inline or externally. Those determine the structure and customization of the components.

Let's take a look at the **{xyz}** component, to get some basic understanding of how components work.

**[Random component text here]**

**[Random component image here]**

Services are special type of components, that are widely available within the application and are accessible by all of the components. Those usually contain shared information and logic, that multiple components need and rely on to be able to function correctly.

The following are the ones used in this application:

**[Angular service files]**

Let's take a look at the **{xyz}** service, to get some basic understanding of how services work.

**[Random service text here]**

**[Random service image here]**

The components can communicate with the backend through services and that is how a full stack application can be achieved.

The styling and design of the web app could have been a downloadable, ready-made template. Instead of that, it was created using Angular Material Design completely from scratch, which was far from an easy task. Quite a few material design modules needed to be imported to the code and it's syntax is super opinionated, which makes it pretty difficult to style even the most uncomplicated elements. Below is an example of a simple password input field.

**[Pw input field code comes here]**

Daniel carried out this part. Js. Angular. Rxjs. Requestek. Material design.

[Top ↑](#top)

### Backend

The backend of the application could be made with TypeScript, just like the frontend, but as most of the tutorials, lessons and walkthroughs are written in plain JavaScript, that's why it was written in vanilla JavaScript. It may be rewritten in TypeScript in the future.

However, some Node packages were needed as it would be quite complicated to code all this without them. Hence the Express backend framework and the MySQL, BodyParser, Bcrypt, CORS and the Nodemon packages were used. Those can be installed all at once like this:

```bash
npm install express mysql cors bodyparser bcrypt nodemon
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

In the following code snippet the cooperation of the Express framework, the BodyParser and the Bcrypt modules can be seen:

**[Blabla register or login snippet]**

The Nodemon package was also super useful. A node server needs to be stopped every single time a code change has been made and needs to be started again, so that the changes would be reflected on the app. Nodemon solves this useless waste of time by automatically restarting the backend every single time the document is saved. It can be imagined as an HTML 'live server' or Angular's 'ng serve', but for the Node.js backend.

Daniel worked mostly on this part, but got help from Jozsef. NodeJS. Express. Cors. Json. Nodemon.

[Top ↑](#top)

### Desktop

Jozsef carried out this part. Lalalaaaa.

### Resources <a id="resources"></a>

## How was it tested? <a id="testing"></a>

### Web app testing <a id="web-testing"></a>

### Desktop app testing <a id="desktop-testing"></a>

[Top ↑](#top)

## What are the limitations? <a id="limitations"></a>

## Which are the future plans? <a id="future-plans"></a>

World domination of course, khm... on a more serious note:

- GitHub, Google, Facebook login possibility
- email intergration for registration and forgotten passwords
- dark mode
- language selector
- public note content search
- secure password check upon registration
- download txt
- upload txt
- rewrite backend in TypeScript
- user profile picture
- note categories
- filter personal and public notes by category

[Top ↑](#top)

## Why was it needed? <a id="why-needed"></a>

Jozsef and Daniel started an adult course and to be able to fulfill all the requirements of it, they needed to deliver a responsive, fullstack app with an optional desktop app, hence these apps were born.

[Top ↑](#top)

## Where was it created? <a id="where-created"></a>

- Made with <3 in Budapest, Hungary.

[Top ↑](#top)

## When was is it developed? <a id="when-developed"></a>

- It was worked on between January and May of 2022.

[Top ↑](#top)

## Who helped? <name id="who-helped"></a>

Special thanks to Róbertné Csilla Dobrocsi, István Bencze, Csaba Kecskeméti and Ifj. István Bencze for their support.

[Top ↑](#top)

## What are the sources? <a id="sources"></a>

Tools used:

Apps used:

Literature used:

C#, Node.js, Angular, angular.io, nodemon, ng-book, angular material, Postman, Cypress,

Code sources:

[Top ↑](#top)
