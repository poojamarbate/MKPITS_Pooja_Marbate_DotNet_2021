#include<stdio.h>
int AreaOfRect(int,int);
int main()
{
 int length,breath,area;
 printf("enter the length and breath:\n");
 scanf("%d%d",&length,&breath);
 
 area=AreaOfRect(length,breath);
 
 printf("Area of rectangle is = %d",area);


}
int AreaOfRect(int l,int b)
{
return l*b;
}

