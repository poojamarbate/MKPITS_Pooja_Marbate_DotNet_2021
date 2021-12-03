var x=5;
var y=4;
var increment;
var decrement;
increment=++x;
document.write("prefix increment ="+increment);
document.write("<br/>");
console.log(increment);

increment=x++;
document.write("postfix increment ="+increment);
document.write("<br>");
console.log(increment)

decrement=--y;
document.write("prefix decrement ="+decrement);
document.write("<br/>");
console.log(decrement);

decrement=y--;
document.write("postfix decrement ="+decrement);
console.log(decrement);
