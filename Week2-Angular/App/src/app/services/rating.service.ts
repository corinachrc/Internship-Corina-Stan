import { Injectable } from '@angular/core';
import { FormControl } from '@angular/forms';


@Injectable({
  providedIn: 'root'
})
export class RatingService {

  constructor() { }

  ratingControl = new FormControl(0);

  rateTheMovie():number{
    if(this.ratingControl.value!=null){
      return this.ratingControl.value;
    }
    return 0;
  }



}
