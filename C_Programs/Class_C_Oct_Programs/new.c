#include<stdio.h>
int main()
{ 
 int i,A[2]={13,14},B[2]={15,10},C[2];
 for(i=0;i<2;i++)
 
   {
   if(A[i]<B[i])
   	   C[i]=A[i];
  else 
       C[i]=B[i];
   }
   printf("C[2]={");
   for(i=0;i<2;i++)
   {
   printf("%d,",C[i]);
   }
   printf("}");
   
  
  return 0;
  
  
  }

