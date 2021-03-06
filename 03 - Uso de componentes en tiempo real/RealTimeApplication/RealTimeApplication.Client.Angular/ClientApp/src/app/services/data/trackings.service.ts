import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import {TrackingModel} from '../../models/tracking.Model';

@Injectable({
  providedIn: 'root'
})
export class TrackingsService {

  trackingsURL = 'https://localhost:44342/api/Trackings';

  constructor(private httpClient: HttpClient) { }

  public list(): Observable<TrackingModel[]> {
    return this.httpClient.get<TrackingModel[]>(`${this.trackingsURL}/`);
  }
  public getByTrackingId(trackingId:number): Observable<TrackingModel> {
    let params = new HttpParams();
    return this.httpClient.get<TrackingModel>(`${this.trackingsURL}/`+trackingId);
  }
}
