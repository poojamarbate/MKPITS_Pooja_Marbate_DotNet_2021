/*WAP to i/p array of 2x3 size and find sum of each row separately and show it after each rowfor elements*/
#include<stdio.h>
int main()
{
int i,j,sum=0,A[2][3];
printf("enter elements of matrix:");

	for(i=0;i<2;i++)
	{
		for(j=0;j<3;j++)
		{
		scanf("%d",&A[i][j]);
		}
	}
	
	printf("given matrix and sum of rows as follows:");
	
	for(i=0;i<2;i++)
	{
	  for(j=0;j<3;j++)
	   {
	     printf("%4d",A[i][j]);
		 sum+=A[i][j];
		 
       }
	   
   printf("  sum = %d  \n",sum);
   
   }
   
   
   return 0;
   
   }	   	   	    
	
		

