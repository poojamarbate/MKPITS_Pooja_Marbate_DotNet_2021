#include<stdio.h>
/*step 1: declaration of prototype*/
void Area_Circle(int);

int main()
{
int radius;
printf("\n enter radius of circle");
scanf("%d",&radius);
Area_Circle(radius);
 
 return 0;
}
/*step 3:defination of function*/

   void Area_Circle(int r)
   {
   float A=3.14*r*r;
   printf("\n Area of circle =%.2f",A);
   }	

