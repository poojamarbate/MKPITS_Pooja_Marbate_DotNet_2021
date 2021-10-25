#include<stdio.h>
#include<malloc.h>
void DisplayArray(int *,int n);

	int main()
   {
	int *number,n,num;
	printf("enter the number of Array");
	scanf("%d",&n);
	number=(int *)malloc(n*sizeof(int));
	printf("enter %d elements",n);
	
		for(num=0;num<n;num++)
		{
		scanf("%d",(number+num));
		 }
	DisplayArray(number,n);
		 
    return 0;

}	 	 	  
		 	  
	
	void DisplayArray(int *A, int n)
    {
		int i;
		printf("\n given array is");
		for(i=0;i<n;i++)
		{
	 		printf("%5d",*(A+i));
     	}     	   
	}


