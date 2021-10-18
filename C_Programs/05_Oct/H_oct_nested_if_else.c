#include<stdio.h>
int main()
{
int num;

printf("enter the number");
scanf("%d", &num);

if (num==0)
{
printf("number is zero");
}
 else
 
 {
 
 if (num>0)
   {
      printf("number is positive\n");
	  
	         if(num%2==0)
			 
			 {
			 printf("%d is positive even number",num);
			 
			 }
			 
			 else
			 
			 {
			  printf("%d is positive odd number",num);
			 } 
   }
  
     else
	    {
  
           printf("number is negative\n");
           
	
			 if(num%2==0)	   	    
			 {
			 printf("\n%d is negative even number",num);
			 
			 }
			 
			 else
			 
			 {
			  printf("%d is negative odd number",num);
			 } 
	
  } 
  
   
 }
  return 0;
  
}


