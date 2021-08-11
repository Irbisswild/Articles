import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-article',
  templateUrl: './article.component.html'
})
export class ArticleComponent {
  @Input() article: Article = null;
}

interface Article {
  id: string,
  title: string,
  content: string,
  createdAt: Date,
  updatedAt: Date
}
