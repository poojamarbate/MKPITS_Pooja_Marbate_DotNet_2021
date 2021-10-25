#include<stdio.h>
int main()
{
   int i,j;
    for(i=5;i>=1;i--) 
   
    {
	  for(j=i;j>=1;j--)
        
          { 
		  if(j%2!=0)
	  //inner loop
	  printf(" 1 ");
	  
		  else
		  printf(" 0 ");
	      }
		  
	 	printf("\n");
	 
	}
	


return 0;

}

