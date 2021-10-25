#include<stdio.h>
int Sum();
int main()
{
printf("sum of 1 to 100\n");

Sum();
}

	int Sum(int a)
	{
	int i,sum=0;
		for(i=1;i<=100;i++)
		{
		 printf("%4d",i);
		 sum+=i;
		 }
		 
		 printf("\nSum = %d",sum);
		 
    }	 	  

