import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class FeatureTypesService {

  constructor(private _http: HttpClient) { }

  getAll() {
    return this._http.get("/api/featuretypes");
  }
}
