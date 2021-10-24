#include<stdio.h>
#include<limits.h>
int main()
{

char a=CHAR_BIT,b=CHAR_MAX;

signed char c=SCHAR_MAX;

unsigned char d=UCHAR_MAX;

short e=SHRT_MAX;

unsigned short f=USHRT_MAX;

int g=INT_MAX;
unsigned int h=UINT_MAX;
long i=LONG_MAX;

unsigned long j=ULONG_MAX;

long long k=LLONG_MAX;

unsigned long long l=ULLONG_MAX;

printf("\n Maximum Int value \na=%d \nb=%d \nc=%d \nd=%d \ne=%d \nf=%d \ng=%d \nh=%d \ni=%d \nj=%d \nk=%d \nl=%d",a,b,c,d,e,f,g,h,i,j,k,l);
return 0;

}

