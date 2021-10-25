#include<stdio.h>
int main()
{
 int month;
 printf("enter the current month number\n");
 scanf("%d",&month);
 switch(month)
 {
 case 1:
        printf("\n Its Jan");
		break;
 case 2:
        printf("\n Its Feb");
		break;	  	  
 case 3:
        printf("\n Its march");
		break;	  	  
 case 4:
        printf("\n Its April");
		break;
 case 5:
        printf("\n Its May");
		break;	  	  
 case 6:
        printf("\n Its June");
		break;
 case 7:
        printf("\n Its July");
		break;
 case 8:
        printf("\n Its Aug");
		break;
 case 9:
        printf("\n Its Sept");
		break;
 case 10:
        printf("\n Its Oct");
		break;
 case 11:
        printf("\n Its Nov");
		break;
 case 12:
        printf("\n Its Dec");
		break;
		
 default:
 	 	 printf("\n Your Selection Is Invalid ");	                                	               
		
 }
 return 0;
 
 } 

