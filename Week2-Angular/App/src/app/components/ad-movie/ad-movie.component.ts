import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { MovieService } from 'src/app/services/movie.service';

@Component({
  selector: 'app-ad-movie',
  templateUrl: './ad-movie.component.html',
  styleUrls: ['./ad-movie.component.css']
})
export class AdMovieComponent {
  addMovieForm: FormGroup;
  isAdmin:boolean;

  constructor(private movieService: MovieService, private router:Router, private authService:AuthService) {
    this.addMovieForm = new FormGroup({
      title: new FormControl('', Validators.required),
      year: new FormControl('', Validators.required),
      runtime: new FormControl('', Validators.required),
      genre: new FormControl('', Validators.required),
      actors: new FormControl('', Validators.required),
      plot: new FormControl('', Validators.required),
      poster: new FormControl('', Validators.required),
      rating:new FormControl('',Validators.required)

    });

    this.isAdmin=authService.getIsAdmin();
  }

  addMovie(): void {
    const { title, year, runtime, genre, actors, plot, poster,rating } = this.addMovieForm.value;
    let firstRating:number[]=[];
    firstRating[0]=rating;

    this.movieService.addMovie({ Title: title, Year: year, Runtime: runtime, Genre: genre, Actors: actors, Plot: plot, Poster: poster,Rating:firstRating, AverageRating:firstRating[0],isVoting:false });


    this.router.navigate(["/movies"]);
  }
}
