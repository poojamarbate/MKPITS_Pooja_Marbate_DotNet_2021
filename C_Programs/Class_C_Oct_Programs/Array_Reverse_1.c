#include<stdio.h>
int main()
{
 int m,n,sum=0,i,j,k;
 int A[3][4],B[4][2],result[3][2];
 
 printf("enter the your 1st matrix");
 
 		for(i=0;i<3;i++)
		{
			for(j=0;j<4;j++)
			  {
			  
			  // printf("enter the %d %d element of first matrix\n",i,j);
			   scanf("%d",&A[i][j]);
			   }
		}
		printf("enter the second matrix\n");	   
		for(i=0;i<4;i++)
		{
			for(j=0;j<2;j++)
			{
			//printf("\nenter the %d %d elements of second matrix\n",i,j);
			scanf("%d",&B[i][j]);
			}
		}
		
		for(i=0;i<3;i++)
		{
			for(j=0;j<2;j++)
			{
			    for(k=0;k<4;k++)
				{
				sum+=A[i][k]*B[k][j];
				}
				result[i][j]=sum;
				sum=0;
			}
		}	 	 
		
		//print the resultant matrix
				for(i=0;i<3;i++)
				{
					for(j=0;j<2;j++)
						{
						  printf("%d\t",result[i][j]);
						 }
						 // printf("\n");
				}	 	   	   	       
return 0;
}

