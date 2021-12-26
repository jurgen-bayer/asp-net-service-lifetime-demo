import {HttpClient} from "@angular/common/http";
import {Inject, Injectable} from "@angular/core";
import {Observable} from "rxjs";
import {DemoResult} from "../model/DemoResult";

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  constructor(private httpClient: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  public getDemoResultFromTransientService(): Observable<DemoResult> {
    return this.getCount('demo/transient');
  }

  public getDemoResultFromScopedService(): Observable<DemoResult> {
    return this.getCount('demo/scoped');
  }

  public getDemoResultFromSingletonService(): Observable<DemoResult> {
    return this.getCount('demo/singleton');
  }

  public increaseCountInTransientService(number: number): Observable<DemoResult> {
    return this.increaseCount('demo/transient', number);
  }

  public increaseCountInScopedService(number: number): Observable<DemoResult> {
    return this.increaseCount('demo/scoped', number);
  }

  public increaseCountInSingletonService(number: number): Observable<DemoResult> {
    return this.increaseCount('demo/singleton', number);
  }

  private getCount(route: string): Observable<DemoResult> {
    console.log(this.baseUrl);
    return this.httpClient.get<DemoResult>(`${this.baseUrl}${route}`);
  }

  private increaseCount(route: string, number: number): Observable<DemoResult> {
    return this.httpClient.post<DemoResult>(`${this.baseUrl}${route}`, number);
  }
}
