#include<stdio.h>
int AreaOfRect(int,int);
int Area_tri(int,int);
float Area_cir(int,float);
int main()
{
 int radius,len,brd,height,A;
 float pi=3.14,area;
 char shape;
 printf("\n press c for Area of circle'\and press r for Area of Rectangle and press t for Area of traingle");
 scanf("%c",&shape);
 shape=getchar();
 switch(shape)
 {
  case 'c':
  case 'C':
           printf("\n enter the value of radius");
		   scanf("%d",&radius);
		   area=Area_cir(radius,pi);
           printf("\n area of circle=%0.2f",area);
		   break ;
		   
  case 'r':
  case 'R':
           printf("\n enter the value of length and breath");
		   scanf("%d%d",&len,&brd);
		   A=AreaOfRect(len,brd);
           printf("\n area of rectangle is =%3d",A);
           break ;
		   
   case 't':
   case 'T':
            printf("\n enter the length and height of triangle");
            scanf("%d%d",&len,&height);
            A=Area_tri(len,height);
            printf("\n area of triangle is =%3d",A);
			break ;
			
			
  default:
          printf("your selection is invalid");
}	 	   	   	   	   
   	   	     
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

