#include<stdio.h>
int AreaOfRect(int,int);
int Area_tri(int,int);
float Area_cir(int,float);
int main()
{
 int radius,len,brd,height,A;
 float pi=3.14,area;
 
 printf("enter the radius :");
 scanf("%d",&radius);
 
 /*call to the function*/
 area=Area_cir(radius,pi);
 printf("\n area of circle=%0.2f",area);
 
 printf("\nenter the length and bridth of rectangle:");
 scanf("%d%d",&len,&brd);
 
 A=AreaOfRect(len,brd);
 printf("\n area of rectangle is =%3d",A);
 
 
 printf("\n enter the length and height of triangle");
 scanf("%d%d",&len,&height);
 
 A=Area_tri(len,height);
 printf("\n area of triangle is =%3d",A);

 

return 0;
}
		int AreaOfRect(int l,int b)
			{
				return l*b;
			}
			
		int Area_tri(int l,int h)
			{
				return l*h;
			}
			
     float Area_cir(int r,float pie)
        { 
          return r*r*pie;
        }

