#include<stdio.h>
int main()
{
int i,j,A[2][3];
printf("\n enter 6 elements of 2x2 array");
for(i=0;i<2;i++)
 {
  for(j=0;j<3;j++)
  {
  scanf("%d",&A[i][j]);
  }
 }
 printf("given array is \n");
 for(i=0;i<2;i++)
 {
  for(j=0;j<3;j++)
  {
  printf("%d",A[i][j]);
  }
  printf("\n");
 }
 
 
return 0;
}

