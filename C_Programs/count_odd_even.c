#include<stdio.h>
int main()
{
 int i,A[10],B[10],C[10],evencount=0,oddcount=0;
  printf("enter 10 elements of array");
  for(i=0;i<10;i++)
  {
   scanf("%d",&A[i]);
   
   }
 
 for(i=0;i<10;i++)
 { 
  if(A[i]%2==0)
    {
    B[i]=A[i];
	evencount++;
    }	 
    
	else
	{
	 C[i]=A[i];
	 oddcount++;
    }
	
 }
 
	printf("\n\ngiven even number are\n");
	
	for(i=0;i<evencount;i++)
	{
	printf("%d",B[i]);
	}
	
	printf("\n\n\nodd number are\n");
	
	for(i=0;i<oddcount;i++)
	{
	printf("%d",C[i]);
	}
	 
	
 return 0;
 
 }	  

