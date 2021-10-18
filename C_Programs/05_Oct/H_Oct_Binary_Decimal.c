#include<stdio.h>
int main()
{
int num,x,temp,i=0,decimal=0;
printf("enter binary number");
scanf("%d",&num);
	
	while(num!=0)
	{
	temp=num%10;
	x=temp*pow(2,i);
	decimal+=x;
	num=num/10;
	i++;
	}
	
	printf("\n the decimal number is =%d\n",decimal);
 return 0;
} 	  
 

