#include<stdio.h>
/*fact(n)=n X fact(n-1)*/
int Fact(int);
int main()
{
int n,N;
printf("enter the number for find factorial");
scanf("%d",&n);
N=Fact(n);
printf("\n factorial of %d = %d ",n,N);

}
  int Fact(int n)
  {
  if(n<=1)
  return 1;
  else
  return n*Fact(n-1);
  }
	

