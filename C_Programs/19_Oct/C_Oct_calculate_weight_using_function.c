#include<stdio.h>
void Kg_Gm(int);
int main()
{
int gm;
printf("enter grams");
scanf("%d",&gm);

Kg_Gm(gm);


return 0;
}
	void Kg_Gm(int grams)
	{
	int kg=grams/1000;
	grams=grams%1000;
	printf("\n grams converted  %d kg and %d gm",kg,grams);
	
	
	}

