#include<stdio.h>
void Mil_Km(int);
int main()
{
int miles;
printf(" enter a distance in miles");
scanf("%d",&miles);
Mil_Km(miles);

}
  void Mil_Km(int m)
  {
  float k=m*1.609;
  printf("\n miles converted %d miles = %.3f kilometer",m,k);
  }

 

