import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MhMaterialModule } from './mh-material.module';

import { LoaderComponent } from '../loader/loader.component';
import { NoWhiteSpaceDirective } from '../directives/no-whitespace.directive';

@NgModule({
    declarations: [
    LoaderComponent,
    NoWhiteSpaceDirective
  ],
   imports: [
    CommonModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    FlexLayoutModule,
    MhMaterialModule
   ],
    exports: [
      CommonModule,
      BrowserAnimationsModule,
      FormsModule,
      ReactiveFormsModule,
      FlexLayoutModule,
      MhMaterialModule,
      LoaderComponent,
      NoWhiteSpaceDirective
    ]
})

export class CoreModule { }
