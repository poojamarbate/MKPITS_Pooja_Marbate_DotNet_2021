#include<stdio.h>
#include<malloc.h>
int main()
{
 float *price,amount=0.0;
 int *qty,i,n;
 
 printf("how many items u want to purchase??\n");
 scanf("%d",&n);
 
 price=(float *)malloc(n*sizeof(float));/*single cell price has ben expaned to block of memory */
 
 qty=(int *)malloc(n*sizeof(int));
 
 for(i=0;i<n;i++)
 {
  printf("\n plz enter price ");
  scanf("%f",(price+i));
  printf("\n how much qty you purchase ");
  scanf("%d",(qty+i));
  amount+=*(price+i)*(*(qty+i));
  
  }
  printf("Total Bill=%f",amount);
 

 
 

 return 0;

}	 	 	 
		

