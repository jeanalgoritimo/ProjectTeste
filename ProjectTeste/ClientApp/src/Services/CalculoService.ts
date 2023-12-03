import { Component, Inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Calculo } from '../Models/Calculo';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class CalculoService {
  private baseUrlExterna: String = "https://localhost:44365/";
  constructor(private httpClient: HttpClient, ) { }

  salvar(formValue: any): Observable<Calculo[]> {
    return this.httpClient.post<Calculo[]>(this.baseUrlExterna + 'api/Calculo', formValue);
  }
}
