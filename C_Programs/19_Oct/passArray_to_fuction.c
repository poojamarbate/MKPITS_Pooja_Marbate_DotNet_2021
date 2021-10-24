#include<stdio.h>
void DisplayArray(int *);
int main()
  {
	int Numbers[]={ 12,10,24,46,36,65,32,33,89,65};
	DisplayArray(Numbers);
	
  }
  
	void DisplayArray(int *A)
  {
	int i;
	for(i=0;i<10;i++)
	{
	 printf("%5d",*(A+i));
     }     	    
	}

