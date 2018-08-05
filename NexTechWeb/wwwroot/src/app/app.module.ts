import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import {HackernewsComponent} from './hackernews/hackernews.component'


@NgModule({
  declarations: [
    AppComponent,
    HackernewsComponent
    
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot([
      { path: 'hackernews', component: HackernewsComponent },
      { path: '', redirectTo: 'hackernews', pathMatch: 'full' },
      { path: '**', redirectTo: 'hackernews', pathMatch: 'full' }
    ]),

  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
