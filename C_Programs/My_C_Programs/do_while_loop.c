#include<stdio.h>
int main()
{
 double number,sum;
 do
 {
 printf("enter number:");
 scanf("%lf",&number);
 sum+=number;
 }
 
 //loop ends when the user enters '0'
 	while(number!=0.0);
	printf("sum =%.2lf",sum);
		
	
	return 0;
}	 
	

