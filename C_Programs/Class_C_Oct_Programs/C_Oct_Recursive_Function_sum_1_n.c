/*recursive function A function which is calls itself from within its body is called recursive

	ntax:   datatype functionname(data)
				{
				if(condition)
				return data;
				 else
				 return (functionname(changedata));
				 }
5!=5 x 4 x 3 x 2 x 1				 
5!=5x4!
fact(n)=n x fact(n-1)

2 power n= 2 x power(n-1)
2 power 3= 2x2x2
			2 x power(3-1)
			=2 x 2 x 2(if(n=1)return 2
			
			SumN=n+Sum(n-1)

*/
#include<stdio.h>
int SumN(int);
int main()
{
	int n,N;
	printf("enter the number 1 to n");
	scanf("%d",&n);
	N=SumN(n);
	printf(" sum of %d=%d",n,N);
	
	
	
	return 0;
}
		int SumN(int n)
		{
				if(n==1)
				return 1;
				else
			    return n+SumN(n-1);
		}	 

