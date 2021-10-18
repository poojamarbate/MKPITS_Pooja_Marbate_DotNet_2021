#include <stdio.h>
int main()
{
 int grams,kg;
 printf("Enter weight in grams");
 scanf("%d",&grams);
 
 kg=grams/1000;
 grams=grams%1000;
 
 printf("the value %d kg %d gm",kg,grams);
  
 return 0; 
}

 

