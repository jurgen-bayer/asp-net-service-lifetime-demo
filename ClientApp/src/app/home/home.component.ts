import {Component, OnInit} from '@angular/core';
import {ApiService} from "../services/ApiService";
import {DemoResult} from "../model/DemoResult";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
  public transientServicesResult?: DemoResult;
  public scopedServicesResult?: DemoResult;
  public singletonServicesResult?: DemoResult;

  constructor(private apiService: ApiService) {
  }

  ngOnInit(): void {
    this.apiService.getDemoResultFromTransientService().subscribe(
      demoResult => {
        this.transientServicesResult = demoResult;
      },
      error => console.error(error));

    this.apiService.getDemoResultFromScopedService().subscribe(
      demoResult => {
        this.scopedServicesResult = demoResult;
      },
      error => console.error(error));

    this.apiService.getDemoResultFromSingletonService().subscribe(
      demoResult => {
        this.singletonServicesResult = demoResult;
      },
      error => console.error(error));
  }

  public increaseTransientServiceCount() {
    this.apiService.increaseCountInTransientService(1).subscribe(
      demoResult => {
        this.transientServicesResult = demoResult;
      },
      error => console.error(error));
  }

  public increaseScopedServiceCount() {
    this.apiService.increaseCountInScopedService(1).subscribe(
      demoResult => {
        this.scopedServicesResult = demoResult;
      },
      error => console.error(error));
  }

  public increaseSingletonServiceCount() {
    this.apiService.increaseCountInSingletonService(1).subscribe(
      demoResult => {
        this.singletonServicesResult = demoResult;
      },
      error => console.error(error));
  }
}
