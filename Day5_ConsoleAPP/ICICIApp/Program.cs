using Banking;
using Taxation;
using Notifications;
﻿using System.Threading;


// Account acct=new Account();
// acct.Balance=15000;
// acct.Deposit(6000);

// TaxationService.PayIncomeTax(5000);
// TaxationService.PaySalesTax(3000);
// TaxationService.PayServiceTax(1500);
// TaxationService.PayGSTTax(6000);

// NotificationServices.SendSMS(" Anshu ", " Paisa hi Paisa hoga ");
// NotificationServices.SendEmail(" Anshu ", " The Lady Jethalal ");
// NotificationServices.SendWhatsAppMessage(" Anshu "," Paisa Dhig ");

// TaxOperation t1 = new TaxOperation(TaxationService.PayIncomeTax);
// t1(5000);

// NotificationOperation emailSender = new NotificationOperation(NotificationServices.SendEmail);
// NotificationOperation smsSender = new NotificationOperation(NotificationServices.SendSMS);
// NotificationOperation WpSender = new NotificationOperation(NotificationServices.SendWhatsAppMessage);

NotificationOperation proxy = null;
// proxy+=emailSender;
// proxy+=smsSender;
// proxy+=WpSender;

// proxy("anshu","Paisa hi paisa hoga");

// proxy-=smsSender;
// proxy("nilesh","Nilesh Mama ");


Account acct45=new Account();
acct45.overBalance+= TaxationService.PayIncomeTax;
acct45.underBalance+= NotificationServices.SendEmail;
acct45.Balance=50000;
acct45.Deposit(300000);
Console.WriteLine("current bal: "+acct45.Balance);
acct45.Withdraw(340000);

IAsyncResult iResult=proxy.BeginInvoke("sarang","Thank you",null,null);
                   

proxy.EndInvoke(iResult);

Thread currentThread=Thread.CurrentThread;
int threadId=currentThread.ManagedThreadId;
Console.WriteLine( "Primary Thread Id="+ threadId);
Console.WriteLine("Primary Thread Prioity: "+ currentThread.Priority);