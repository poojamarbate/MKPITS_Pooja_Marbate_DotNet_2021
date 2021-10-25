#include<stdio.h>
int main()
{
 int m,n,p,q,A[3][4],B[4][2],result[3][2];
 int i,j,k;
/* printf("enter the 3 row of A matrix\n");
 scanf("%d",&m);
 printf("\nenter the 4 column of A matrix\n");
 scanf("%d",&n); 
 
 printf("\nenter the 4 row of B matrix\n");
 scanf("%d",&p);
 printf("\nenter the 2 column of A matrix");
 scanf("%d",&q);
 
 			if(n==p)
			{
			printf("\n multiplication possible");
			}
			else
			{
			printf("\n multiplication is not possible");
			}
  */
  printf("give the input A matrix");
  			for(i=0;i<3;i++)
				{
					for(j=0;j<4;j++)
						{
							scanf("\n%d",&A[i][j]);
						}
				}	 	 	 
  	printf("give the input B matrix");
				for(i=0;i<4;i++)
					{
						for(j=0;j<2;j++)
						{
						 scanf("%d",&B[i][j]);
						 }
					}	  	  	  
  
  					    for(i=0;i<3;i++)
  						  {
   							for(j=0;j<2;j++)
								{
								result[i][j]=0;
			
		  						  for(k=0;k<4;k++)
									{
									result[i][j]+=A[i][k]*B[k][j];
									}

 	    						 }
						    }	 
		
					printf("\n multipilcation matirx is\n");
	
						for(i=0;i<3;i++)
	 					 {
	    					for(j=0;j<2;j++)
		 						 {
		 						 printf("%4d",result[i][j]);
		 						 }
		  
		 						printf("\n");
	  					} 
							    		 
  return 0;
  }
 

