#include<stdio.h>
/* n factorial= 1 * 2 *3.....n */
int main()
{
int n,fact=1,i;
printf("enter any number which you find Factorial\n");
scanf("%d",&n);

		if(n<0)
		{
		printf("!!!ERROR!!!");
		}
		
		else
		{
		for(i=2;i<=n;++i)
		{
		fact*=i;
		}
		printf("Factorial of = %d",fact);
		}

	 
	 return 0;
	 
}

