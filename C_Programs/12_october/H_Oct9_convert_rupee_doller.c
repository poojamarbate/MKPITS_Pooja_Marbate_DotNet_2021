#include<stdio.h>
float Rupee_Doller(int);
int main()
{
 int rupee;
 printf("enter rupee");
 scanf("%d",&rupee);
 Rupee_Doller(rupee);
}
float Rupee_Doller(int rs)
{
 float doller=rs/74.49;
 
 printf("\n rupee conveted %d rupee = %.2f $",rs,doller);
 
 }
 




