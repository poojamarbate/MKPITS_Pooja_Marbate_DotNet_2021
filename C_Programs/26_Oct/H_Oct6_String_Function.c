#include<stdio.h>
int main()
{
 char a[20]="poojamarbate",b[20];
 printf("Length of string is :%d",strlen(a));
 
 strcpy(b,a);
 
 printf("\n\nValue of Second String is:%s",b);
 
 strcat(a,b);
 printf("\n\nValue of first string is:%s",a);
 
 printf("\n1st string:");
 gets(a);
 printf("\n2nd string:");
 gets(b);
 if(strcmp(a,b)==0)
 printf("string is equal");
 else
 printf("Not Equal");
 
 printf("\nEnter a string: ");
 gets(a);
 strrev(a);
 printf("THE REVERSE STRING:%s",a);
 
 printf("\nEnter a string:");
 gets(a);/*reading string from console*/
 printf("string is:%s",a);
 printf("\n Lower String is:%s",strlwr(a));
 printf("\n Upper case string is:%s",strupr(a));
 
 
 
 
 }
 

