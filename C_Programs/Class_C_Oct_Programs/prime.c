#include<stdio.h>
int main()
{
   int n,i,m=0;
   char isprime='y';
   printf("enter the number to check for prime:");
   scanf("%d",&n);
   m=n/2;
   for(i=2;i<=m;i++)
   { 
    if(n%i==0)
	{
	 printf("number is not prime");
	 isprime='n';
	 break;
	 }
	 }
	 if(isprime=='y')
	 
	 printf("number is prime");

return 0;

}

