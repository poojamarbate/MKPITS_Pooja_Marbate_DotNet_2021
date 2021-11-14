function validate()
{
  var age=parseInt(prompt("enter age"));
  var ans="not eigible";
    if(age>=18)
    {
      ans="eligible";
    }
    return(ans);
}
var status=validate();
document.write(" you are <b> "+status+"</b> for vote");