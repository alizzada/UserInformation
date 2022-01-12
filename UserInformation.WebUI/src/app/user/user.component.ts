import { Component, OnInit } from '@angular/core';
import { User } from '../models/user.model';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent implements OnInit {
  users:User[];

  constructor(private _userService:UserService) { }

  ngOnInit(): void {
    this.getAllUsers();
  }

  getAllUsers() {
    return this._userService.getAllUsers().subscribe((response ) => {
      this.users = response;
    }, (err) => {
      console.log(err);
    });
  }

}
