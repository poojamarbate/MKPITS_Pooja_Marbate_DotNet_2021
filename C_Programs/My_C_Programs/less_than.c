//campare the number to find greatest number in given list
#include<stdio.h>
int main()
{
 int A[]={26,45,67,100,124},min=1000,i;
for(i=0;i<5;i++)
{
  if(A[i]<min)
  min=A[i];
 } 
 printf("\n smallest number =%d",min);
 
return 0;
}

