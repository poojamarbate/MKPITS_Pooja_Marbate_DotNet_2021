//campare the number to find greatest number in given list

#include<stdio.h>
int main()
{
 int A[]={26,45,67,100,124},max=0,i;
for(i=0;i<5;i++)
{
  if(A[i]>max)
  max=A[i];
 } 
 printf("\n greatest number =%d",max);
 
return 0;
}

