#include<stdio.h>
int main()
{
 int number;
 
 printf("enter a number");
 scanf("%d",&number);
 
 if(number>=0)
 {
 printf("%d is positive or zero.\n",number);
 printf("body of if is executed");
 }
  
 else
 { 
 printf("%d is negetive.\n",number);
 printf("body of else executed");

 }
 
 

  return 0;
  
}  

