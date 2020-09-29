import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PhonesService {

  constructor(private _http: HttpClient) { }

  getAll() {
    return this._http.get("/api/phones");
  }
}
