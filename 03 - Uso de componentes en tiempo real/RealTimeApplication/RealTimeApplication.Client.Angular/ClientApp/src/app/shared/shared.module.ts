import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule } from './material.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import { ApexChartModule } from './apex-chart/apex-chart.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MaterialModule,
    ApexChartModule,
    FlexLayoutModule
  ],
  exports: [
    MaterialModule,
    ApexChartModule,
    FlexLayoutModule
  ]
})
export class SharedModule { }
