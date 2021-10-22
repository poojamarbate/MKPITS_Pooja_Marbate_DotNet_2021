#include<stdio.h>
int main()
{
 int number;
 
 printf("enter a number");
 scanf("%d",&number);
 
 if(number>0)
 {
 printf("%d is positive.\n",number);
 }
  
 else if(number==0)
 { 
 printf("%d is zero.\n",number);
 }
 
 else
 {
 printf("%d is negetive",number);
 }
 
 

  return 0;
  
}  

