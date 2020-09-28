import { Component, OnInit } from '@angular/core';
import { FeatureTypesService } from '../feature-types.service';

@Component({
  selector: 'app-suggesting-phone',
  templateUrl: './suggesting-phone.component.html',
  styleUrls: ['./suggesting-phone.component.css']
})
export class SuggestingPhoneComponent implements OnInit {
  $featureTypes;
  
  constructor(private featureService: FeatureTypesService) { }

  ngOnInit() {
    this.$featureTypes = this.featureService.getAll();
  }

}
