#include<stdio.h>
int main()
{
 int A[]={1,2,3,4,5},B[]={6,7,8,9,10},C[10],i,j;
 for(i=0;i<10;i++)
 {
  if(i<5)
  { C[i]=A[i];}
  
   else if(i==5) 
   { C[i]=B[i-5];}
   
   else
   {
   j=i-5;
  
   C[i]=B[j];
   }
 }   
printf("\n Array of C is as follow");
for(i=0;i<10;i++)
{
printf("%4d",C[i]);
}
printf("\n\n\n reverse of array is \n");
for(i=9;i>=0;i--)
{
printf("%4d",C[i]);
}
return 0;
}

