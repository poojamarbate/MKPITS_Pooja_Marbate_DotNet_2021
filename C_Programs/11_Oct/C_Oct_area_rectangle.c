#include<stdio.h>
/*declaration*/
float AreaCircle(int,float);
int AreaRect(int,int);
float AreaTri(int,int);

int main()
{
 int i,l=40,b=20, radius;
 float A,pie=3.14;
 for(i=0;i<3;i++)
 {
 printf("\nenter the radius:");
 scanf("%d",&radius);
  
 A= AreaCircle(radius,pie);
 
  printf("\n Area of circle=%6.2f and radius=%d",A,radius);
 } 
printf("\n Area of rectangle=%d",AreaRect(l,b));

printf("\n Area of triangle=%6.2f",AreaTri(200,100));

 return 0;

}	 	 	 

// user defined function:step 2 is

float AreaCircle(int r,float p)
{
return p*r*r;
}

int AreaRect(int l,int b)
{
return l*b;
}	 	 
float AreaTri(int b ,int h)
{
return 0.5*b*h;
}

