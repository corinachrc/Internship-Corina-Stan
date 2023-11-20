import { FormControl } from '@angular/forms';
import { Component, Input } from '@angular/core';
import { RatingService } from 'src/app/services/rating.service';
import { movie } from 'src/app/models/movie';
import { MovieService } from 'src/app/services/movie.service';
import { Output } from '@angular/core';


@Component({
  selector: 'app-star-rating',
  templateUrl: './star-rating.component.html',
  styleUrls: ['./star-rating.component.css']
})
export class StarRatingComponent {

constructor(private ratingService:RatingService){

}
votingOpen=false;

ratingFormControl=this.ratingService.ratingControl;

onRating(){
  return this.ratingService.rateTheMovie();
}

onSaveRating() {


}
}
