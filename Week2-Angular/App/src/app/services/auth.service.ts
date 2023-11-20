import { Injectable } from '@angular/core';
import { user } from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor() { }
users:user[]=[
  {
    username:"admin",
    password:"1111"
  },
  {
    username:"corina",
    password:"1234",
  },
  {
    username:"vali",
    password:"1234"
  }
]

isLoggedIn=false;

isAdmin=false;

currentUser:string=""

  login(credentials:any){
    const user = this.users.find(u => u.username === credentials.username && u.password === credentials.password);

    if (user) {
      this.isLoggedIn = true;
      this.isAdmin = user.username === 'admin';
      this.currentUser=user.username;
    } else {

      this.isLoggedIn=false;
      this.isAdmin=false;
    }
  }



  logout(): void {
    this.isLoggedIn = false;
    this.isAdmin = false;
  }

  getIsLoggedIn(): boolean {
    return this.isLoggedIn;
  }

  getIsAdmin(): boolean {
    return this.isAdmin;
  }

}


