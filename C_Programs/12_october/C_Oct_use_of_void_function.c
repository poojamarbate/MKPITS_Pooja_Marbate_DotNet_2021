#include<stdio.h>
/*step 1: declaration of prototype*/
void PrintLine();
void InputMessage();
int main()
{
int a,b,c;
PrintLine();
InputMessage();
scanf("%d%d",&a,&b);
c=a+b;
printf("\nc=%d",c);
PrintLine();
return 0;
}
/*step 3:defination of function*/
void PrintLine()
{
printf("\n.............\n");
}
void InputMessage()
{
 printf("enter two numbers\n");
 }

