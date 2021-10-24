#include<stdio.h>
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

*/
int Fact(int);
int main()
{
	int n=5,N;
	N=Fact(n);
	printf("\n Factorial Of %d = %d ",n,N);
	
	return 0;
}
int Fact(int n)
{
	if(n<=1)
	return 1;
	else
	return n*Fact(n-1);
}	 

