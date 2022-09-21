import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'pushpin'
})
export class PushpinPipe implements PipeTransform {

  transform(value:any): any {
    return "📌"+value;
  }

}
