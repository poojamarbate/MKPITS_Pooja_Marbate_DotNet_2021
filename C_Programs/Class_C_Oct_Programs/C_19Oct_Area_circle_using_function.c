/*using function find out area of circle*/
/*pre processor directive */
#include<stdio.h>
/*declartion prototype*/
float AreaofCircle(int,float);
/*global variable declartion*/ 
int main()
{  
 int radius;
 float pi=3.14,area;
 printf("enter the radius of circle");
 scanf("%d",&radius);
 
 area=AreaofCircle(radius,pi);
 
 printf("The area of circle is = %0.2f",area);
 
 printf("\nThe area of circle is = %0.2f",AreaofCircle(5,3.14));
 
 

 }
 
 float AreaofCircle(int r,float pie)
 {
 return r*pie*r;
 }
 
 

