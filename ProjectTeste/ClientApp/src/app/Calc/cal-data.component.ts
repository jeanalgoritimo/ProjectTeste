import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, map } from 'rxjs';
import { Calculo } from '../../Models/Calculo';
import { CalculoService } from '../../Services/CalculoService';

@Component({
  selector: 'app-calc-data',
  templateUrl: './calc-data.component.html'
})
export class CalcDataComponent {
  public calculo: Calculo[] = [];
  constructor(private calculoService: CalculoService) { }

  onSubmit(formValue: any): void {
      this.calculoService.salvar(formValue).subscribe(
        res => {
          this.calculo = res;
          if (this.calculo.length == 0) {
            alert('Atenção é necessário preencher os valores')
          }
        },
        error => {
          console.log(error);
        }
      );
  }
}





