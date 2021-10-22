#include<stdio.h>
/*declaration*/
float AreaCircle(int,float);

int main()
{
 int i, radius;
 float A,pie=3.14;
 for(i=0;i<3;i++)
 {
 printf("\nenter the radius:");
 scanf("%d",&radius);
  
 A= AreaCircle(radius,pie);
 
  printf("\n Area of circle=%6.2f and radius=%d",A,radius);
 } 

 return 0;

}	 	 	 

// user defined function:step 2 is

float AreaCircle(int r,float p)
{
return p*r*r;
}	 	 

