#include<stdio.h>
int main()
{
char ch1 = -128;
char ch2 = 'a';

short s = 10;
int i = 1000;

unsigned int ui = 45555;

long l = 1234567;

unsigned long ul = 1234567898;

float f = 3.5f;

double d = 23.9999;

long double ld = 23.239;


printf("char value : %c \n", ch1);
printf("signed numerical value of char : %hhi \n", ch1);
printf("char value : %c \n", ch2);
printf("short value : %hi \n", s);
printf("int value : %d \n",i);
printf("unsigned int value : %u \n", ui);
printf("long value : %ld \n", l);
printf("unsigned long value : %ul \n", ul);
printf("float value : %f \n ", f);
printf("double value : %lf \n", d);

return 0;
}


 

