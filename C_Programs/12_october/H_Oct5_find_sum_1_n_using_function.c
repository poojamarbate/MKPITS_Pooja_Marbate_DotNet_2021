#include<stdio.h>
void Sum(int);
int main()
{
int range;
printf("Up to which number you want to find sum:");
scanf("%d",&range);
Sum(range);
}

void Sum(int n)
{
int i,add=0;

	for(i=1;i<=n;i++)
	{
	add+=i;
	}
printf("Sum Of 1 to n = %d",add);
	}

