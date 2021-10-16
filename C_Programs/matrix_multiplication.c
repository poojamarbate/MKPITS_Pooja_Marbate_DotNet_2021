#include<stdio.h>
int main()
{
int A[10][10],B[10][10],m,n,p,q,i,j,k,C[10][10];
printf("enter how many rows in matrix");
scanf("%d",&m);
printf("enter how many columns in matrix");
scanf("%d",&n);
printf("number of rows");
scanf("%d",&p);
printf("number of columns");
scanf("%d",&q);
if(n==p)
{
 printf("multiplication is possible\n");
} 
  else
  {
   printf("multiplication is not possible\n");
  }   
  
  printf("\n give input for matrix A");
  for(i=0;i<m;i++)
 {
  for(j=0;j<n;j++)
  {
  scanf("%d",&A[i][j]);
  }
 }
  printf("\n give input for matrix B");
 for(i=0;i<p;i++)
 {
  for(j=0;j<q;j++)
  {
  scanf("%d",&B[i][j]);
  }
 }
 
  
  
  for(i=0;i<m;i++)
  {
   		for(j=0;j<q;j++)
		{
		C[i][j]=0;
		  	for(k=0;k<n;k++)
			{
			C[i][j]+=A[i][k]*B[k][j];
			}

 	    }
	}	 
		
		printf("\n multipilcation matirx is\n");
	
	for(i=0;i<m;i++)
	  {
	    for(j=0;j<q;j++)
		 {
		  printf("%4d",C[i][j]);
		  }
		  
		 printf("\n");
	  } 
	    	
 return 0;

}	 	 	 
		

