#include<stdio.h>
int main()
{
   int myarray[5],i;
   printf("\n enter 5 numbers");
   for(i=0;i<5;i++)
   {
   scanf("%d",&myarray[i]);
   
   } 
   printf("\n given array is");
   for(i=0;i<5;i++)
   {
   printf("%3d",myarray[i]);
   }
return 0;

}

