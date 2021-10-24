/* preprocessor directive*/
#include<stdio.h>
/*our function needs to return some integer at the end of the execution */
int main()
{
/*assignment operator*/
int a=1;
int b=1;
/*logical OR operator pre-decrement operator and result is assign in 'c'*/
int c=a||--b;
/*logical AND operator post-decrement operator and pre-decrement operator result store in 'd '*/
int d=a--&&--b;
/*function is used to print any statement*/
printf("a=%d,b=%d,c=%d,d=%d",a,b,c,d);

return 0;

}



