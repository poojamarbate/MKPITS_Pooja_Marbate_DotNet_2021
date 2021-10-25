#include<stdio.h>
void Cube(int);
void Cone(int,int);
void Cyclinder(int,int);
void Sphere(int);
int main()
{
int edge,radius,height;
char shape,reply='y';

do
{
printf("Press A for cube\nPress B for Cone\nPress C for Cyclinder\nPress D for Sphere\n");
fflush(stdin);
shape=getchar();
	
		   switch(shape)
		   {
		
			case 'A':
			case 'a':
			         printf("Enter the size of edge to find Volume of Cube:");
					 scanf("%d",&edge);
					 Cube(edge);
					 break;
			case 'B':
			case 'b':	 	  
					 printf("\nEnter Radius and Height to find Volume of Cone:");
					 scanf("%d%d",&radius,&height);
					 Cone(radius,height);
					 break;
			case 'C':
			case 'c':	 	  	     	 
					 printf("\nEnter Radius and Height to find Volume of Cyclinder:");
					 scanf("%d%d",&radius,&height);
					 Cyclinder(radius,height);
					 break;
			case 'D':
			case 'd':	 	  
					 printf("Enter the Radius To Find Volume Of Sphere");
					 scanf("%d",&radius);
					 Sphere(radius);
					 break;
				   	   
				   	   	   	   
			default:printf("Invalid Selection");				
				   	   	   
	 	 }	 	 	 	 	 
		
			
			printf("\n Do you Want find volumne of solid Again Press y for yes and n for no!!!!\n");
			fflush(stdin);
			reply=getchar();
			continue;
		}
		while(reply=='y');	  
			
	return 0;
	
}
		void Cube(int a)
		{
		int cube=a*a*a;
		printf("Volume Of Cube = %d",cube);
		}
		void Cone(int r,int h)
		{
		float cone=0.33*h*3.14*r*r;
		printf("Volume of Cone = %.2f",cone);
		}
		void Cyclinder(int r,int h)
		{
		float cyclinder=3.14*r*r*h;
		printf("Volume Of Cyclinder = %.2f",cyclinder);
		}
		void Sphere(int r)
		{
		float sphere=1.33*r*r*r*3.14;
		printf("Volume Of Sphere = %.2f",sphere);
		}

