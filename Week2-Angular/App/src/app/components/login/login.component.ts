import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  constructor(private authService:AuthService,
    private route:ActivatedRoute,
    private router:Router){}
  signInForm=new FormGroup({
    username: new FormControl('',Validators.required),
    password: new FormControl('', Validators.required)
  })

  isValid=true;
  isAdmin=false;
  currentUsername:string='';
  onSignIn(){
    this.authService.login(this.signInForm.value);
    this.isValid=this.authService.getIsLoggedIn();
    if(this.isValid){
      this.router.navigate(["/movies"]);
      this.currentUsername=this.authService.currentUser;
    }
    else{
      this.signInForm.reset();
    }
    if(this.authService.getIsAdmin()){
      this.isAdmin=this.authService.getIsAdmin();
    }
  }



}
