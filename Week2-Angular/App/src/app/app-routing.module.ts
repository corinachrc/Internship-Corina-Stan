import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { MovieComponent } from './components/movie/movie.component';
import { AuthGuard } from './guards/auth.guard';
import { AuthAdminGuard } from './guards/auth-admin.guard';
import { AdMovieComponent } from './components/ad-movie/ad-movie.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'movies', component: MovieComponent, canActivate: [AuthGuard] },
  { path: 'add-movie', component: AdMovieComponent, canActivate: [AuthAdminGuard] },
  { path: '', redirectTo: '/login', pathMatch: 'full' },
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
