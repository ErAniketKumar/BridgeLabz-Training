import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'trimText',
})
export class TrimTextPipe implements PipeTransform {
  transform(value: string, ...args: number[]): unknown {
    if (args.length > 0) {
      value = value.substring(0, args[0]);
    } else {
      value = value.substring(0, 20) + '...';
    }
    return value;
  }
}
