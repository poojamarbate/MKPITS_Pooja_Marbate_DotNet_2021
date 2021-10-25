#include<stdio.h>
int factorial(int);
int main()
{
int n,r,ncr;
printf("enter a  number for n and r\n");
scanf("%d%d",&n,&r);
ncr=factorial(n)/(factorial(r)*factorial(n-r));
printf("\n ncr factorial of %d and %d is %d\n",n,r,ncr);

}
int factorial(int num)
{
if(num)
return (num*factorial(num-1));
else
return 1;
}

