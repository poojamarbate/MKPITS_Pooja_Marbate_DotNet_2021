#include<stdio.h>
int main()
{
int a,b,c;
   
printf("enter any three number");
scanf("%d %d %d",&a,&b,&c);

  if(a<b && a<c)
 {
 printf("%d",a);
 }
  else if(b<c)
  {
  printf("%d",b);
  }
  else 
   printf("smallest number is %d",c);
  
 return 0;
 
 }

