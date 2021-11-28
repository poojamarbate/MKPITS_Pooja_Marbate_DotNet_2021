#include<stdio.h>
int main()
{
int n;
printf("enter any number you want to check number is 0 or +ve or -ve and even or odd.");
scanf("%d",n);
if(n==0)
{
printf("number is zero");
}
else if(n>=0)
{
printf("number is positive");
}
else
printf("Number is negetive");

if(n%2==0)
{
printf("Number is Even");
}
else
printf("Number is negetive");
  
 return 0;
 
 }

