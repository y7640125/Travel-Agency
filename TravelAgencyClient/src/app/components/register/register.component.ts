import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { User } from 'src/app/_models/user.model';
import { AdminService } from 'src/app/_services/admin.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.less']
})
export class RegisterComponent implements OnInit {

  constructor(
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private dialogRef: MatDialogRef<RegisterComponent>,
    private adminService: AdminService,
    private router: Router
  ) { }
  userId!: number;
  hide = true;

  form = this.fb.group({
    userId: this.fb.control('0'),
    roleId: this.fb.control('2'),
    name: this.fb.control('', [Validators.required]),
    password: this.fb.control(
      '',
      Validators.compose([
        Validators.pattern(
          '(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[$@$!%*?&])[A-Za-zd$@$!%*?&].{7,}'
        ),
      ])
    ),
    email: this.fb.control('', Validators.compose([Validators.email])),
    advertisements: this.fb.control('')
  });

  validate(): boolean {
    return true;
  }
  ngOnInit(): void { }
  
  close() {
    if (this.dialogRef && this.dialogRef.close) {
      this.dialogRef.close({ data: 'Order' });
    }
  }
  saveUser() {
        const user = this.form.value;
        // this.adminService.saveUser(user).subscribe((x) => {
          Swal.fire('', 'השמירה בוצעה בהצלחה', 'success').then(() => {
            this.close();
          })
          this.router.navigateByUrl('/login');
        // })
  }

}
