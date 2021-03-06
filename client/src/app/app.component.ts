import { BasketService } from './basket.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
  title = 'My Store';

  constructor(private BasketService: BasketService) {}

  ngOnInit(): void {
    const basketId = localStorage.getItem('basket_id');

    if (basketId) {
      this.BasketService.getBasket(basketId).subscribe(() => {
        
      })
    }
  }


}
