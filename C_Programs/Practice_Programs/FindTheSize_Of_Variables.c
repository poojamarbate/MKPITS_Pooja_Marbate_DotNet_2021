#include<stdio.h>
int main()
{

 int inttype;
 long int longtype;
 float floattype;
 double doubletype;
 char chartype;
 
 // sizeof given the size in bytes
 
 printf("int:%zu \n",sizeof(inttype));
 printf("double:%zu\n",sizeof(doubletype));
 printf("char:%zu\n",sizeof(chartype));
 printf("float:%zu",sizeof(floattype));

 
 return 0;
 }

