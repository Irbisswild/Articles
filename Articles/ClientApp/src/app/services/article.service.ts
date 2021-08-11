import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Article } from '../Models';

@Injectable()
export class ArticleService {
  private articles: Article[];

  constructor(private http: HttpClient) {
    this.loadArticles();
  }

  getArticles() {
    return this.articles;
  }

  loadArticles() {
    return this.http.get<Article[]>('https://localhost:44368/api/article');
  }
}
