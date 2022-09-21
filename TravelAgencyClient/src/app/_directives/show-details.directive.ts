import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appShowDetails]'
})
export class ShowDetailsDirective {

  constructor(private el: ElementRef) { }

  @HostListener('mouseover') onMouseOver() {
    this.el.nativeElement.querySelector('.background').style.height='100%';
    this.el.nativeElement.querySelector('.show').style.display='block';
  }

  @HostListener('mouseout') onMouseOut() {
    this.el.nativeElement.querySelector('.background').style.height='25%';
    this.el.nativeElement.querySelector('.show').style.display='none';
  } 

}
