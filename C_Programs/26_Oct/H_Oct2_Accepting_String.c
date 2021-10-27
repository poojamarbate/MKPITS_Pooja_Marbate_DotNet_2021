#include<stdio.h>
int main()
{
 char a[20];
 printf("Enter a String?\n");
 /*scanf("%s",a);         it does't work for space */
 
 scanf("%[^\n]s",a);
 printf("You Entered :%s",a);
 
 }

