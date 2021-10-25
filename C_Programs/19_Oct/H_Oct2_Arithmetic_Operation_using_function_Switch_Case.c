#include<stdio.h>
void Add(int,int);
void Sub(int,int);
void Mul(int,int);
void Div(int,int);
void Mod(int);
int main()
{
 int num1,num2,n;
 char operator; 
 printf("Menu\n Press A for Add\n Press S for Sub\n Press M for Mul\n Press D for Div\n Press F for Modulus\n");
 operator=getchar();
     
   switch(operator)
       {
	case 'A':
	case 'a':
			 printf("Enter two number for Addition Operation:");
	         scanf("%d%d",&num1,&num2);
	         Add(num1,num2);
	         break;
	         
	 
	case 'S':
	case 's':
			 printf("\n\nEnter two number for Substration Operation:");
	         scanf("%d%d",&num1,&num2);
	         Sub(num1,num2);
	         break;
 
	         
 
	case 'M':
	case 'm':
	        printf("\n\nEnter two number for Multiplication Operation:");
	        scanf("%d%d",&num1,&num2);
	        Mul(num1,num2);
	        break;
		    
	 
	case 'D':
	case 'd':
	      	printf("\n\nEnter two number for Division Operation:");
	        scanf("%d%d",&num1,&num2);
	        Div(num1,num2);
	        break;
		    
	  
	case 'F':
	case 'f': 
			printf("\n\nEnter a number for finding Modulus");
	        scanf("%d",&n);
	        Mod(n);
	        break;
	          
			
	default:
	        printf("\nInvalid selection");	  	  
		
  }
  
  return 0;
 
}
	void Add(int a,int b)
	{
	 int Addition=a+b;
	 printf("\n Addition of two number =%d",a+b);
	 
	} 
	void Sub(int a,int b)
	{
	int Substration=a-b;
	printf("\n Substration of two number = %d",a-b);
	}
	void Mul(int a,int b)
	{
	int Multiplication=a*b;
	printf("\n Multiplication of two number = %d",a*b);
	}
	void Div(int a,int b)
	{
	int Division=a/b;
	printf("\n Division of two number = %d",a/b);
	}
	void Mod(int a)
	{
	int modulus=a%2 ;
	printf("\n Modulus of a number = %d",a%2);
	
	}

