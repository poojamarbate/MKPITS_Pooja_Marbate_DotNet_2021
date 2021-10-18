#include<stdio.h>
int main()
{
 int sec,min,hr,temp,temp2;
 
 printf("enter time in second:");
 scanf("%d",&sec);
 
 hr=sec/3600;
 temp=sec%3600;
 min=temp/60;
 temp2=temp%60;
 
 
 printf(" %d sec = %d hr %d min %d sec ",sec,hr,min,temp2);
 
 return 0;

}

