import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable } from '../../../node_modules/rxjs';
import { IArticle } from './article';
import { environment } from '../../environments/environment';
import { catchError, tap, map } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
  })
export class HackerNewsService{
    constructor(private http: HttpClient) { }

    getBestStories(): Observable<any[]>{
        return this.http.get(environment.apiUrl).pipe(
            map(res => <IArticle[]>res)
            //, tap(data => console.log('All: ' + JSON.stringify(data)))
            , catchError(err=> Observable.throw(this.handleError))

        )
    }


    private handleError(err: HttpErrorResponse) {
        // just logging it to the console
        let errorMessage = '';
        if (err.error instanceof ErrorEvent) {
          // A client-side or network error occurred. Handle it accordingly.
          errorMessage = `An error occurred: ${err.error.message}`;
        } else {
          // The backend returned an unsuccessful response code.
          // The response body may contain clues as to what went wrong,
          errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
        }
    }
}