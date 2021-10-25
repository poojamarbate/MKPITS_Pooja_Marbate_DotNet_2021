#include<stdio.h>
int main()
{
   int i,A[3]={ 12,23,34},B[3]={10,20,30},C[3];
   for(i=0;i<3;i++)
   {
   C[i]=A[i]+B[i];
   
   } printf(" Addition of two array\n{");
   
   for(i=0;i<3;i++)
   
   {
   
   printf("%3d",C[i]);
   
   }
   printf("}");
   
   /*C[3]=A[3]+B[3];
   
   printf(" %d",C[3]);*/
return 0;

}

