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
  displayedPhones: any[];
  filter : any = {};

  constructor(private featureService: FeatureTypesService,
              private phoneService: PhonesService) { }

  ngOnInit() {
    forkJoin([
      this.featureService.getAll(),
      this.phoneService.getAll()
    ]).subscribe((data : any) => {
      this.featureTypes = data[0];
      this.phones = this.displayedPhones = data[1];
    });
  }

  resetFilter() {
    this.filter = {};
    this.onFeatureChange();
  }

  onFeatureChange() {
    this.displayedPhones = this.phones;
    for (let featureTypeId in this.filter) {
      var featureId = parseInt(this.filter[featureTypeId]);
      if (featureId === 0) continue;
      this.displayedPhones = this.displayedPhones
        .filter(p =>  p.featuresIds.indexOf(featureId) > -1);
    }
  }


}
