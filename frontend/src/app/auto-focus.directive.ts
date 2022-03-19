import { Directive, ElementRef } from '@angular/core';

@Directive({
  selector: '[auto-focus]',
})
export class AutoFocusDirective {
  constructor(private elementRef: ElementRef) {}

  ngAfterViewInit() {
    this.elementRef.nativeElement.focus();
  }
}
