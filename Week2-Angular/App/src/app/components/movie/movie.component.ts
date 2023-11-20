import { Component } from '@angular/core';
import { MovieService } from 'src/app/services/movie.service';
import { AuthService } from 'src/app/services/auth.service';
import { Router } from '@angular/router';
import { movie } from 'src/app/models/movie';


@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})
export class MovieComponent {

  movies: movie[];
  isAdmin:boolean;
  isValid:boolean;
  username:string;

  constructor(private movieService:  MovieService, private user:AuthService, private router:Router) {
    this.movies = this.movieService.getMovies();
    this.isAdmin=user.getIsAdmin();
    this.isValid=user.getIsLoggedIn();
    this.username=user.currentUser;
  }

  onAddMovie(){
    this.router.navigate(['/add-movie']);
  }

  onRemoveMovie(movie:movie) {
    this.movies=this.movieService.deleteMovie(movie);
    }

  onLogOut() {
    this.user.currentUser="";
    this.isValid=false;
    this.router.navigate(['']);
    return this.isValid;
    }

  onVote(movie:movie) {
    movie.isVoting=true;
  }

  onSavingVote(movie:movie){
    movie=this.movieService.addRating(movie);
  }

}


