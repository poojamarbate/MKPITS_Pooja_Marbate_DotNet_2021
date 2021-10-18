#include<stdio.h>
int main()
{
int a=10,b=20;
printf("before swap number is\n a=%d b=%d",a,b);

a=a+b;
b=a-b;
a=a-b;

printf("\nafter swap number is \n a=%d b=%d",a,b);
 

return 0;
  

 
 }

