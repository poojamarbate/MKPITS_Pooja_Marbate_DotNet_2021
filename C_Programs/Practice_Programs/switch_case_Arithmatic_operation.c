#include<stdio.h>
int main()
{
int num1,num2,result;
char operator;
printf("Menu\nPress '+' for Addition(add)\nPress '-' for Substration(sub)\nPress '*' for Multiplication(multi)\nPress '/' for Division(div)\n");
scanf("%c",&operator);
printf(" enter the numbers to perform the operation\n");
scanf("%d %d",&num1,&num2);

	switch(operator)
	{
		case '+':
				 printf("result = %d",num1+num2);
				 break;	
				 
		case '-':
		         printf("result = %d",num1-num2);
				 break;
				 
		case '*':
				 printf("result = %d",num1*num2);
				 break;
				 
		case '/':
				 printf("result = %d",num1/num2);
				 break;
				 
		default: printf("Error!!Operation is not correct");	   	    		 
				 	 	 	  
				 
	 }
	 
	 return 0;	  	  	      	   


}

