import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import {IArticle} from './article';
import {HackerNewsService} from './hackernews.service'

@Component({
  selector: 'pm-hackernews',
  templateUrl: './hackernews.component.html',
  styleUrls: ['./hackernews.component.css']
})
export class HackernewsComponent implements OnInit {

  constructor(private hackerNewsService: HackerNewsService) { }
  
  articles: IArticle[] = [];

  ngOnInit() {
    this.hackerNewsService.getBestStories().subscribe(
      data => {this.articles = data;
      console.log(JSON.stringify(this.articles));
      });

  }
  

}
