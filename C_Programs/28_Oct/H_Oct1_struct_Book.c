/*pass structure to the function using pointer*/


#include<stdio.h>

typedef struct 
{
 int day,month,year;
}date;


typedef struct 
{
int bookid,edition_no;
char book_name[50],book_author[50];
float price;
date publish_date;

}book;

/*void display(book*);*/


main()
{
 book b1;
 printf("*************************   Book Details   *******************************");
 
		 printf("\n\n\n\nBookID: ");
		 scanf("%d",&b1.bookid);
		 printf("\nBook Name: ");
		 scanf("%s",&b1.book_name);
		 printf("\nAuthor Name:");
		 scanf("%s",&b1.book_author);
		 printf("\nBook EditionNo: ");
		 scanf("%d",&b1.edition_no);
		 printf("\nBook Price:");
		 scanf("%.2f",&b1.price);
		 
		 printf("\nPublish Date of Book: ");
		 fflush(stdin);
		 scanf("%d/%d/%d",b1.publish_date.day,b1.publish_date.month,b1.publish_date.year);
	
 return 0;
 
 } 
/*void display(book *e)
{
 int i;
 for(i=0;i<3;i++)
 {
 printf("\nBookID:%d\nBook Name:%s\nAuthor Name:%s\nBook Edition no:%d\nBook Price:%.2f\nPublish Date of Book:%d/%d/%d",(e+i)->bookid,(e+i)->book_name,(e+i)->book_author,(e+i)->edition_no,(e+i)->price,(e+i)->publish_date);
 }
} 
*/

