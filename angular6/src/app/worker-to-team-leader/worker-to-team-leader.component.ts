import { Component, OnInit } from '@angular/core';
import { ManagerService } from '../shared/services/manager.service';
import { User } from '../shared/models/user';

@Component({
  selector: 'app-worker-to-team-leader',
  templateUrl: './worker-to-team-leader.component.html',
  styleUrls: ['./worker-to-team-leader.component.css']
})
export class WorkerToTeamLeaderComponent implements OnInit {
  teamLeaders: User[];

  constructor(public managerService:ManagerService) {

   }

  ngOnInit() {
    this.managerService.getUsersByDepartment("teamLeader").subscribe(res=>{
      this.teamLeaders=res;
    })
  }


  updateWorkers(id:number)
  {
    
  }

}
