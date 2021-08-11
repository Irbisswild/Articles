import { Component, OnInit } from '@angular/core';
import { Article } from '../Models';
import { ArticleService } from '../services/article.service';

@Component({
  selector: 'app-article-list',
  templateUrl: './article-list.component.html'
})
export class ArticleListComponent implements OnInit {
  public articles: Article[];

  constructor(private articleService: ArticleService) {}

  ngOnInit() {
    this.articleService.loadArticles().subscribe(result => {
      this.articles = result;
    }, error => console.error(error));;
  }
}
