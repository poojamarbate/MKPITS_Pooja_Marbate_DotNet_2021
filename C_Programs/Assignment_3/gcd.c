#include <stdio.h>
int main()
{
    int n1, n2;
    
    Input:printf("\nEnter two positive integers: \n");
          scanf("%d %d",&n1,&n2);

    while(n1!=n2)
    {
        if(n1 > n2)
            n1 -= n2;
        else
            n2 -= n1;
    }
	
    printf("GCD = %d",n1);
	
	goto Input;
	
    return 0;
}

