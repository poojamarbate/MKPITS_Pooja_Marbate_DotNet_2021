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
			
3 power 3=3 x 3 x 3
3 power n = 3  x power(n-1)  if(n=1)return3	   	   	   

*/
#include<stdio.h>
int Power(int);
int main()
{
	int n,N;
	printf("enter the number which you want to find 3th power");
	scanf("%d",&n);
	N=Power(n);
	printf("3th power of %d=%d",N,n);
	
	
	
	return 0;
}
		int Power(int n)
		{
				if(n==1)
				return 3;
				else
			    return n+Power(n-1);
		}	 

