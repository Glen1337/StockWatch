import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];
  public portfolios: Portfolio[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Portfolio[]>(baseUrl + 'api/Portfolios').subscribe(result => {
      this.portfolios = result;
      console.log(this.portfolios);
    }, error => console.error(error));
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

interface Portfolio {
  title: string;
}
