#include<stdio.h>
int main()
{
 int i,j,n,qty;
 float price,amount,bill=0.0;
 printf("how many items you purchase? ");
 scanf("%d",&n);
 for(i=0;i<n;i++)
 {
 printf("\nenter price\n");
 scanf("%f",&price);
 printf("quntity\n");
 scanf("%d",&qty);
 
 amount=price*qty;
 }
 printf("items   price   qty   amount\n");
 for(i=0;i<3;i++)
 {
 j=i+1;
 printf("%5d %3.f %d  %4.3f",j,price,qty,amount);
 bill+=amount;
 }
 printf("\n total bill rs./%4.2f",bill);
  
 return 0;
 
 }

