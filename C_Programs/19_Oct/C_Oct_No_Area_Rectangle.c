#include<stdio.h>
/*step 1: declaration of prototype*/
float Area_Circle();
int Area_Rect();
float Area_Tri();
int main()
{
 float A;
 int area;
 A=Area_Circle();
 printf("\n Area of circle=%.2f",A);
 
 area=Area_Rect();
 printf("\n Area of Rectangle=%4d",area);
 
 A=Area_Tri();
 printf("\n Area of Triangle =%.2f",A);
 return 0;
}
/*step 3:defination of function*/

		float Area_Circle()
		{
		int r;
		printf("\n enter radius ");
		scanf("%d",&r);
		return 3.14*r*r;
		
		}
		
       int Area_Rect()
	   {
	    int l,b;
		printf("\n enter length and breath");
		scanf("%d%d",&l,&b);
		return l*b;
		}
		
       float Area_Tri()
	   {
	   int b,h;
	   printf("\n enter length and height");
	   scanf("%d%d",&b,&h);
	   return (h*b)/2;
	   }

