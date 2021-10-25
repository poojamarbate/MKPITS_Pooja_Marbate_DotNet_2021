#include<stdio.h>
int main()
{
int i,num1,num2,gcd;
 Input:printf("enter two number which you want to find gcd",num1,num2);
       scanf("%d %d",&num1,&num2);
 
 /*gcd(grestest common factor)
 remainder=0*/
 
 for (i=1; i<=num1 && i<=num2;++i)
  {
  
  // if i is factor of both number
  
  if(num1%i==0 &&  num2%i==0);
  gcd=i;
  
  }
  printf("G.C.D of %d and %d is %d",num1,num2,gcd);
 goto Input;
  
 return 0;
 }


