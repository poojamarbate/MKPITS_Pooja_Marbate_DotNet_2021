#include<stdio.h>
/*function to return max value*/
int Max(int,int);
int Min(int,int);
void ShowMax_Min(int,int);
int main()
{
 	int x=10,y=100,a=123,b=564,N1,N2;
	ShowMax_Min(x,y);
	ShowMax_Min(a,b);
	
	
	printf("\n\nenter two number to find max and min\n");
	scanf("%d%d",&N1,&N2);
	ShowMax_Min(N1,N2);
	
	
	return 0;
	
}
/*function to find maximum*/
		int Max(int a,int b)
		{
		if(a>b)
		return a;
		else
		return b;
		}
/*function to find minimum*/

		int Min(int a,int b)
		{
		if(a<b)
		return a;
		else
		return b;
		}
		
/*to show maximum and minimum both*/		
 void ShowMax_Min(int a,int b)
 {
 printf("\n max no is %d and min no is %d\n",Max(a,b),Min(a,b));
 }

