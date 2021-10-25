#include<stdio.h>
int main()
{
   float price[3],amount[3],bill=0.0;
   int i,j,qty[3];
   for(i=0;i<3;i++)
   {
   
   printf("\nenter the price\n");
   scanf("%f",&price[i]);
   printf("\n how many purchased");
   scanf("%d",&qty[i]);
   amount[i]=price[i]*qty[i];
   }
   printf("\n Items   price    qty    amount\n");
   for(i=0;i<3;i++)
   {
   j=i+1;
   printf("\n%4d %.3f %5d %.2f\n ",j,price[i],qty[i],amount[i]);
   bill+=amount[i];
   }
   printf("\n total bill Rs./%4.2f",bill);
return 0;

}

