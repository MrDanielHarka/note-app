import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-slideshow',
  templateUrl: './slideshow.component.html',
  styleUrls: ['./slideshow.component.css'],
})
export class SlideshowComponent implements OnInit {
  constructor() {}

  activePicture = 0;

  slides = [
    {
      image: 'assets/developers.jpg',
      toptext: 'developers.',
      bottomtext: '(on desktop)',
    },
    {
      image: 'assets/recruiters.jpg',
      toptext: 'recruiters.',
      bottomtext: '(on laptop)',
    },
    {
      image: 'assets/teachers.jpg',
      toptext: 'teachers.',
      bottomtext: '(on tablet)',
    },
    {
      image: 'assets/couriers.jpg',
      toptext: 'couriers.',
      bottomtext: '(on phone)',
    },
    {
      image: 'assets/anyone.jpg',
      toptext: 'anyone.',
      bottomtext: '(anywhere)',
    },
  ];

  slideshow() {
    this.activePicture = 0;
    for (let [index] of this.slides.entries()) {
      if (index < this.slides.length - 1) {
        setTimeout(() => {
          this.activePicture++;
        }, 3000 * (index + 1));
      }
    }
  }

  ngOnInit(): void {
    this.slideshow();

    // let changeImage = setInterval(() => {
    //   this.activePicture++;
    // }, 3000);
  }
}
