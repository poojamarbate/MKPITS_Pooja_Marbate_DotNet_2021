#include<stdio.h>
	void Swap(int *,int *);
	int main()
	{
	
		int x=100,y=200;
		printf("\n Before swap x=%d and y=%d",x,y);
		Swap(&x,&y);
		printf("\n After swap x=%d and y=%d",x,y);

	
	}
	void Swap(int *a,int *b)
	{
	 int temp;
	 
	 temp=*a;
	 *a=*b;
	 *b=temp;
	 }

