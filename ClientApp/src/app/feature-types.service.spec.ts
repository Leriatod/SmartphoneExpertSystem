import { TestBed } from '@angular/core/testing';

import { FeatureTypesService } from './feature-types.service';

describe('FeatureTypesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: FeatureTypesService = TestBed.get(FeatureTypesService);
    expect(service).toBeTruthy();
  });
});
