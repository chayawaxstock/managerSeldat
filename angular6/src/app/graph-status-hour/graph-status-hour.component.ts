import { Component, OnInit } from '@angular/core';
import { WorkerService } from '../shared/services/worker.service';
import { UserService } from '../shared/services/user.service';

@Component({
  selector: 'app-graph-status-hour',
  templateUrl: './graph-status-hour.component.html',
  styleUrls: ['./graph-status-hour.component.css']
})
export class GraphStatusHourComponent implements OnInit {

  barChartOptions: any;
  barChartLabels: any;
  barChartType: any;
  barChartLegend: any;
  barChartData: any;

  constructor(public workerService:WorkerService,public userService:UserService) { }

  ngOnInit() {

     this.barChartOptions = {
      scaleShowVerticalLines: false,
      responsive: true
    };
     this.barChartLabels = ['2006', '2007', '2008', '2009', '2010', '2011', '2012'];
     this.barChartType = 'bar';
     this.barChartLegend = true;
   
     this.barChartData = [
      {data: [65, 59, 80, 81, 56, 55, 40], label: 'Series A'},
      {data: [28, 48, 40, 19, 86, 27, 90], label: 'Series B'}
    ];

    this.workerService.getHoursForUserProjects(this.userService.currentUser.userId).subscribe(
      res=>{
        
      }
    )
  }

  // events
  public chartClicked(e:any):void {
    console.log(e);
  }
 
  public chartHovered(e:any):void {
    console.log(e);
  }

}
