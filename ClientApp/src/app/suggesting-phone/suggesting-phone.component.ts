import { PhonesService } from './../phones.service';
import { Component, OnInit } from '@angular/core';
import { FeatureTypesService } from '../feature-types.service';
import { forkJoin } from 'rxjs';

@Component({
  selector: 'suggesting-phone',
  templateUrl: './suggesting-phone.component.html',
  styleUrls: ['./suggesting-phone.component.css']
})
export class SuggestingPhoneComponent implements OnInit {
  featureTypes : any[];
  phones : any[];
  constructor(private featureService: FeatureTypesService,
              private phoneService: PhonesService) { }

  ngOnInit() {
    forkJoin([
      this.featureService.getAll(),
      this.phoneService.getAll()
    ]).subscribe((data : any) => {
      this.featureTypes = data[0];
      this.phones = data[1]
    });
  }
}
