import { TestBed } from '@angular/core/testing';

import { DataServiesService } from './data-servies.service';

describe('DataServiesService', () => {
  let service: DataServiesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DataServiesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
