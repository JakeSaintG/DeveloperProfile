import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'pro-navigation-bar',
  templateUrl: './navigation-bar.component.html',
  styleUrls: ['./navigation-bar.component.css']
})
export class NavigationBarComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  test = () => {
    console.log("meep"); 
  }
  
}
