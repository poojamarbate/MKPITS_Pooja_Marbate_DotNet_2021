#include<stdio.h>
/*declaration*/
float AreaCircle(int,float);
int AreaRect(int,int);
float AreaTri(int,int);

int main()
{
int r,l,b,base,height;
char shape;
printf("\n to find area press for c for circle\n press r for rectangle\n press t for triangle");
shape=getchar(); 

switch(shape)
{
case 'C':
case 'c':	printf("enter the radius of circle");
			scanf("%d",&r);
			printf("\n radius=%d and area of circle=%6.2f\n",AreaCircle(r,3.14));
			break;
			
case 'R':
case 'r':	printf("\nenter length and breath"); 
			scanf("\n%d%d",&l,&b);
			printf("\n area of rectangle=%d\n",AreaRect(l,b));
			break;
			
case 'T':
case 't':	printf("\n enter base and height");
			scanf("%d%d",&base,&height);
			printf("\n area of triangle=%6.2f\n",AreaTri(base,height));
			break;
			
default:	printf("invalid key press");
			
			
 }
 return 0;
 
 }	  

// user defined function:step 2 is

float AreaCircle(int r,float p)
{
return p*r*r;
}
/*area of rectangle*/
int AreaRect(int l,int b)
{
return l*b;
}
/*area of triangle*/		
float AreaTri(int B ,int H)
{
return 0.5*B*H;
}

