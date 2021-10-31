/*WAP create a struct date and struct patient with following fields 

PatientId
FirstName
LastName
Age
Diagnosis
Doctor Name
Appointment Date
*/

#include<stdio.h>

typedef struct 
{
 int day,month,year;
}date;


typedef struct 
{
int PatientId,Age,Time;
char First_Name[50],Last_Name[50],Doctor_Name[50]; 
char Diagnosis[50];
date Appointment_Date;

}patient;


int main()
{
 patient p;
 
 printf("**********************************  Patient Details  *********************************************");
 
 printf("\n\n\n\nPatientId:: ");
 scanf("%d",&p.PatientId);
 printf("\nPatient Age:: ");
 scanf("%d",&p.Age);
 printf("\nFirst Name:: ");
 scanf("%s",&p.First_Name);
 printf("\nLast Name:: ");
 scanf("%s",&p.Last_Name);
 printf("\nDoctor Name:: ");
 scanf("%s",&p.Doctor_Name);
 printf("\nDiagnosis:: ");
 scanf("%s",&p.Diagnosis);
 
 printf("\nenter a date in this formate :dd/mm/yyyy\n "); 
 printf("\nAppointment Date:: ");
 fflush(stdin);
 scanf("%d/%d/%d",&p.Appointment_Date.day,&p.Appointment_Date.month,&p.Appointment_Date.year);
 
 printf("\nEnter a Timing in this formate : 00:00 - 00:00\n "); 
 printf("\nAppointment Timing:: ");
 scanf("%d",&p.Time);

}

