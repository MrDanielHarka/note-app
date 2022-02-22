import { Directive, AfterViewInit, ElementRef } from '@angular/core';

@Directive({
  selector: '[autofocus]',
})
export class AutoFocusDirective {
  constructor(private elementRef: ElementRef) {}

  ngAfterViewInit() {
    this.elementRef.nativeElement.focus();
  }
}
