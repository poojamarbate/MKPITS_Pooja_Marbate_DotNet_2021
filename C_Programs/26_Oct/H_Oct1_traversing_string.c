/* count the vowels in string
#include<stdio.h>
int main(){
 char a[15]="poojamarbate";
 int i,count=0;
 	for(i=0;i<15;i++)
	{
	 if(a[i]=='a'||a[i]=='e'||a[i]=='i'||a[i]=='o'||a[i]=='u')
	 		{
			 count++;
			 }
			 
     }
	 
	 printf("the number of vowels %d",count);
	 
	 return 0;
}	  	  	  	   
 */
 #include<stdio.h>
 int main()
 {
 char a[15]="poojamarbate";
 int i=0,count=0;
 
 	while(a[i]!=NULL)
	{
	 	if(a[i]=='a'||a[i]=='e'||a[i]=='i'||a[i]=='o'||a[i]=='u')
		  {
		   count++;
           }		   
       i++;
     }
 printf("the number of vowels %d ",count);
 
 return 0;
 }	   	      

