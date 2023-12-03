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
  private PodeSalvar: boolean | undefined;
  constructor(private calculoService: CalculoService) { }

  onSubmit(formValue: any): void {
    this.PodeSalvar = true;
    console.warn(formValue.Prazo)
    if (formValue.Prazo < 0) {
      this.PodeSalvar = false;
      alert('Atenção Prazo não pode ser negativo')
    }
    if (formValue.ValorInicial < 0) {
      this.PodeSalvar = false;
      alert('Atenção Valor Inicial não pode ser negativo')
    }
    if (this.PodeSalvar == true)
    {
      this.calculoService.salvar(formValue).subscribe(
      res => {
        this.calculo = res;
        console.log(this.calculo);
      },
      error => {
        console.log(error);
      }
    );
    }
    
  }
}





