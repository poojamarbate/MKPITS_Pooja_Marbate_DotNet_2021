#include<stdio.h>
int main()
{
 int n=65,num,k;
 printf("%d in binary number system is:\n",n);
 
 for(num=10;num>=0;num--)
 {
  k=n>>num;
   if(k&1)
    printf("1");
	else
	printf("0");
 }
 printf("\n");
 
 return 0;
} 	  
 

