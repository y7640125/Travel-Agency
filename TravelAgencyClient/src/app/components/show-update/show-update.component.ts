import { Component, OnInit } from '@angular/core';
import { Update } from 'src/app/_models/update.model';
import { AdminService } from 'src/app/_services/admin.service';

@Component({
  selector: 'app-show-update',
  templateUrl: './show-update.component.html',
  styleUrls: ['./show-update.component.less']
})
export class ShowUpdateComponent implements OnInit {

  constructor(private adminServer: AdminService) { }

  updates!:Update[];
  update!:Update;
  stop!:any
  i=0;

  ngOnInit(): void {
    this.adminServer.getAllUpdates().subscribe((x)=>{
      this.updates=x;
      this.start();});
  }
  
 start(){
    this.changeUpdate();
    this.stop= setInterval(() => {this.changeUpdate(); }, 2000);
}
  changeUpdate():void{
    
      if(this.i<this.updates.length)
      this.update=this.updates[this.i++];
      else
      this.i=0;
  }
  stopInterval(){
    clearInterval(this.stop)
}
getUpdates(){
  return this.updates;
}

}
