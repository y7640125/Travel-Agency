import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/_models/user.model';
import { TokenStorageService } from 'src/app/_services/token-storage.service';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.less']
})
export class MenuComponent implements OnInit {
user: User|undefined;
  constructor(
    private tokenStorage: TokenStorageService,
    public dialog: MatDialog,
    private router: Router) {
      if (this.tokenStorage.getToken()) {
        this.user = <User>this.tokenStorage.getUser().user;
      }
      this.tokenStorage.userChanged.subscribe((x) => {
        if (x) {
          this.user = <User>this.tokenStorage.getUser().user;
        } else {
          this.user = undefined;
        }
      });
     }

  ngOnInit(): void {
  }
  
  logout() {
    this.tokenStorage.signOut();
    this.user = undefined;
    this.router.navigateByUrl('Home');
  }
}
