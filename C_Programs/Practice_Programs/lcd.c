#include<stdio.h>
int main()
{
int i,n1,n2,max;
       printf("enter two number\n");
       scanf("%d %d",&n1,&n2);
 
 max=(n1>n2)?n1:n2;
 
 while(1){
  if(max%n1==0 && max%n2==0)
  {
  printf("the LCM of %d and %d is %d.",n1,n2,max);
  break;
  
  }
  +++max;
  
  }
 
  
 return 0;
 }


