#include<stdio.h>
/*step 1: declaration of prototype*/
void Area_Circle(int);
void Area_Rect(int,int);
void Area_Tri(int,int);

int main()
{
int radius,len,brd;
float base,height;
printf("\n press C for Circle\nPress T for Triangle\n press R for Rectangle\n");
/* we can use scanf also in place of shape=getchar() */
fflush(stdin);
/* std input stream of bytes is flused*/
char shape;
shape=getchar();
switch(shape)
{

/*printf("\n how many times you want to find area of circle ? ");
scanf("%d",&n);
for(i=0;i<n;i++)*/

	case 'c':
	case 'C':printf("\n enter radius of circle");
             scanf("%d",&radius);
             Area_Circle(radius);
			 break;

	case 'r':
	case 'R':printf("\n Enter length of Rectanle");
             scanf("%d",&len);
             printf("\n enter the breath of rectangle");
             scanf("%d",&brd);
             Area_Rect(len,brd);
			 break;

	case 't':
	case 'T':printf("\n enter height of Triangle");
			 scanf("%f",&height);
			 printf("\n enter base of triangle");
			 scanf("%f",&base);
			 Area_Tri(base,height);
			 break;
			
	default:printf("Invalid Select");
	
	}	 	 	 
				
				 
 return 0;
}
/*step 3:defination of function*/

   void Area_Circle(int r)
   {
   float A=3.14*r*r;
   printf("\n Area of circle =%.2f",A);
   }
   	 void Area_Rect(int l,int b)
	 {
	 int A=l*b;
	 printf("\n The Area of Rect =%4d",A);
	 }
	 
     void Area_Tri(int b,int h)
	 {
	 float A=0.5*b*h;
	 printf("\n The Area of Triangle is =%.2f",A);
	 }

