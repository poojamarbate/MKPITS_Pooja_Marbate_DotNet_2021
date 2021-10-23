#include<stdio.h>
void Doller_Rs(int);
int main()
{
int doller;
printf(" enter the amount in $");
scanf("%d",&doller);

Doller_Rs(doller);

}
void Doller_Rs(int d)
{
 float rupee=d*74.99;
 printf(" doller converted %d $ = %.2f rupee",d,rupee);
 
 }


