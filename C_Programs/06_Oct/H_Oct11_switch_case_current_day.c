#include<stdio.h>
int main()
{
 char week;
 printf("Enter the current day of week\n");
 scanf("%d",&week);
 switch(week)
 {
 case 1:
 		  printf(" Its Monday");
		  break ;
 case 2:
          printf("Its Tuesday");
		  break ;
 case 3:
          printf("Its wendesday");
		  break ;
 case 4:
        printf("Its Thusday");
		break ;
 case 5:
        printf("Its Friday");
		break ;
 case 6:
        printf("Its Saturday");
		break ;
 case 7:
        printf("Its Sunday,Time For Hoilday");	
		break ;
 default:
         printf("You Enter InValid"); 	    	
 	 	  	  	  
 }	  	     
return 0;
}	 	   	   

