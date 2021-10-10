#include<stdio.h>
int main()
{
int n;
printf("Number is 0 or +ve or -ve and even or odd.\n");
scanf("%d",&n);

if(n==0)
{
printf("Number is zero");
}
else if(n>=0)
{
printf("Number is +ve");
}
else
{
printf("\nNumber is -ve");
}
if(n%2==0)
{
printf("\nNumber is Even");
}
else
{
printf("\nNumber is odd");
}  
 return 0;
 
 }

