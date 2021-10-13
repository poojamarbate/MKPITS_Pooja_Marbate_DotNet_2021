#include<stdio.h>
int main()
{
int i,n;
printf("enter any 10 number");
for(i=0;i<10;i++)
{
scanf("%d",&n);
if(n%2==0)
{  
 printf("\teven=%d\n",n);
 
 }
  else
  {
  
  printf("odd=%d\a",n);
  
  }
 }
 
 return 0;
 
 }


