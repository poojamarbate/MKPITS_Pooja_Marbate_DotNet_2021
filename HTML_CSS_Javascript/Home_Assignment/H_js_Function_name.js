var fname,lname;
fname=prompt("enter first name","Pooja");
lname=prompt("enter a last name","Marbate");
fullname=Fullname(fname,lname);
console.log(fullname);

function Fullname(f,l)
{
return f + "  "+ l;
}
