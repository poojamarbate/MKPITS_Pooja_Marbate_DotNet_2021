#include<stdio.h>
/*step1: declaration of prototype n */
int SumN(int);
PrintLine();
int main()
{
int limit;
printf("\n enter upper limits to find sum of 1 to n number:");
scanf("%d",&limit);
printf("\n sum of 1 to %d = %d",limit,SumN(limit));
PrintLine();
return 0;
}
/*step2:defination of function*/

			int SumN(int n)
			{
			int i,s=0;
			for(i=1;i<=n;i++)
			   {
			    s+=i;
               }
			   return s;
             }	  	  	     	 	 	 	 
/*void function example*/

PrintLine()
{
 printf("\n...........\n");
 printf("\n............\n");
 }

