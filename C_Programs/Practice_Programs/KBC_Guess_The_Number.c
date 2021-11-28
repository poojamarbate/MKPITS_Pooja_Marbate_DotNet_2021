#include<stdio.h>
int main()
{

int number=39,guessed_number;

printf("enter a any number '1 to 100':");

/*test condition*/
 		while(1)
		{
		scanf("%d",&guessed_number);
		/*if user guess is larger number*/
				if(guessed_number>number)
				{
				 printf("WRONG!!!!Enter a smaller number:");
				} 
				
			/*if user guess the smaller number*/
			    else
				   if (guessed_number<number)
				   {
				   printf("WRONG!!!!Enter a larger number:");
				   }
			/*if user guess correct number print message and end the game*/
			
				   else	
				   {
				   printf("\n\a\a\aCongratulations!!!!!Correct guess.");
				   printf("\nYou Win the Game");
				   break;
				   }
			}	       	    
	 
	 return 0;
	 
}

