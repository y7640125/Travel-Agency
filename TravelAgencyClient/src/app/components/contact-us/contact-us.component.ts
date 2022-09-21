import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Message } from 'src/app/_models/message.model';
import { AdminService } from 'src/app/_services/admin.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html',
  styleUrls: ['./contact-us.component.less']
})
export class ContactUsComponent implements OnInit {

  form!: FormGroup;

  constructor(
    private dialogRef: MatDialogRef<ContactUsComponent>,
    private fb: FormBuilder,
    private adminServer: AdminService,
    @Inject(MAT_DIALOG_DATA) public data: any,
  ) {
    this.form = this.fb.group({
      name: this.fb.control('', [Validators.required]),
      email: this.fb.control('', Validators.compose([Validators.email])),
      subject: this.fb.control('', Validators.required),
      message1: this.fb.control('',[ Validators.required]),
    })
  }
  ngOnInit(): void {}
  close() {
    if (this.dialogRef && this.dialogRef.close) {
      this.dialogRef.close({ data: 'Order' });
    }
  }
  sendMessage() {
    const message=this.form.value;
    this.adminServer.sendMessage(message).subscribe((x)=>{
      Swal.fire("", "ההודעה נשלחהה", 'success').then(()=>{
        this.close();
      })
    })
    }

}
