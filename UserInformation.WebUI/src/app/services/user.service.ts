import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { User } from '../models/user.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private httpClient:HttpClient) { }

  readonly baseUrl='http://localhost:5027/api/user';

  getAllUsers(): Observable<User[]> {
    return this.httpClient.get<User[]>(this.baseUrl);
  }
}
