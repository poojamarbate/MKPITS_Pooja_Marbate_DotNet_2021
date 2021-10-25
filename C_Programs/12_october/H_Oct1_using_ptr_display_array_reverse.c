/*WAP using pointer i/p array of n size and display it in reverse order*/
#include<stdio.h>
#include<malloc.h>
int main()
{
int i,n,*myarray;
printf("enter the size of array:");
scanf("%d",&n);
myarray=(int *) malloc( n* sizeof(int));
printf("enter %d elements of array",n);

for(i=0;i<n;i++)
{
scanf("%d",(myarray+i));
}
printf("given Array is:");

for(i=n-1;i>=0;i--)
{
printf("%4d",*(myarray+i));
printf("\n%0x",(myarray+i));
}
return 0;

}

