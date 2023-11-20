import { Injectable } from '@angular/core';
import { movie } from '../models/movie';
import { RatingService } from './rating.service';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor(private ratingService:RatingService) {

    localStorage["movies"] = JSON.stringify(this.movies);



  }
  ngOnInit(): void {


  }
  movies: movie[] = [
    {
      Title: "Guardians of the Galaxy Vol. 2",
      Year: "2017",
      Runtime: "136 min",
      Genre: "Action, Adventure, Comedy",
      Actors: "Chris Pratt, Zoe Saldana, Dave Bautista",
      Plot: "The Guardians struggle to keep together as a team while dealing with their personal family issues, notably Star-Lord's encounter with his father, the ambitious celestial being Ego.",
      Poster: "https://m.media-amazon.com/images/M/MV5BNjM0NTc0NzItM2FlYS00YzEwLWE0YmUtNTA2ZWIzODc2OTgxXkEyXkFqcGdeQXVyNTgwNzIyNzg@._V1_SX300.jpg",
      Rating: [9.0],
      isVoting:false
    },
    {
      Title: "The Nun",
      Year: "2018",
      Runtime: "96 min",
      Genre: "Horror, Mystery, Thriller",
      Actors: "Demián Bichir, Taissa Farmiga, Jonas Bloquet",
      Plot: "A priest with a haunted past and a novice on the threshold of her final vows are sent by the Vatican to investigate the death of a young nun in Romania and confront a malevolent force in the form of a demonic nun.",
      Poster: "https://m.media-amazon.com/images/M/MV5BMjM3NzQ5NDcxOF5BMl5BanBnXkFtZTgwNzM4MTQ5NTM@._V1_SX300.jpg",
      Rating: [8.0],
      isVoting:false
    },
    {
      Title: "Cast Away",
      Year: "2000",
      Runtime: "143 min",
      Genre: "Adventure, Drama, Romance",
      Actors: "Tom Hanks, Helen Hunt, Paul Sanchez",
      Plot: "A FedEx executive undergoes a physical and emotional transformation after crash landing on a deserted island.",
      Poster: "https://m.media-amazon.com/images/M/MV5BN2Y5ZTU4YjctMDRmMC00MTg4LWE1M2MtMjk4MzVmOTE4YjkzXkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_SX300.jpg",
      Rating: [8.5],
      isVoting:false
    }
  ]

  getMovies(): any[] {
    let moviesDb = localStorage.getItem("movies");
    if (moviesDb != null) {
      this.movies = JSON.parse(moviesDb);
    } else {
      moviesDb = '';
      this.movies = JSON.parse(moviesDb);
    }
    this.movies.forEach(element => {
      element.AverageRating=this.getAverageRating(element);
    });
    return this.movies;
  }
  addMovie(movie: movie): void {
    let moviesDb = localStorage.getItem("movies");
    if (moviesDb != null) {
      this.movies = JSON.parse(moviesDb);
    } else {
      moviesDb = '';
      this.movies = JSON.parse(moviesDb);
    }

    this.movies.push(movie);
    localStorage.setItem("movies", JSON.stringify(this.movies));

  }

  getAverageRating(movie:movie){
    let total=0;
    let average=0;
    if(movie.Rating!=undefined){
      movie.Rating.forEach(element => {
        total+=element
    })
    average=total/movie.Rating.length;
    };

    return average;
  }
updateLocalStorage(movie:movie){
  this.movies=this.getMovies();
  let index=this.movies.findIndex(obj=>obj.Title==movie.Title);
  this.movies[index]=movie;
  localStorage.setItem("movies", JSON.stringify(this.movies));
}
addRating(movie:movie){
  movie.Rating.push(this.ratingService.rateTheMovie()*2);

  movie.AverageRating=this.getAverageRating(movie);
  movie.isVoting=false;
  this.updateLocalStorage(movie);

return movie;

}
  deleteMovie(movie: movie) {
    let moviesDb = localStorage.getItem("movies");
    if (moviesDb != null) {
      this.movies = JSON.parse(moviesDb);
    } else {
      moviesDb = '';
      this.movies = JSON.parse(moviesDb);
    }
    this.movies = this.movies.filter(obj => obj.Title != movie.Title);
    localStorage.setItem("movies", JSON.stringify(this.movies));
    return this.movies;
  }


}
