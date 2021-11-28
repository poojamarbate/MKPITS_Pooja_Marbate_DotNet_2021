#include<stdio.h>
int main()
{
 int number1,number2 ,num;
 printf("enter two number which you want multiplication table");
 scanf("%d  %d",&number1,&number2);
 
 for(num=1;num<=10;num++)
 {
 
 number1*num;
 number2*num;
  printf("\n%d   \t%d\n",number1*num,number2*num);
  
  
 }
 
 return 0;
 
 } 

