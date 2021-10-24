#include<stdio.h>
/*step 1: declaration of prototype*/
float Area_Circle();
int main()
{
 float A;
 A=Area_Circle();
 printf("\n Area of circle=%.2f",A);
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

