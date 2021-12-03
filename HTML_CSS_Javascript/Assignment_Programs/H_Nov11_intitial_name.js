const fullName1 = "Noah William";
const fullName2 = "Jackson";

const getInitials = (name) => {
  let initials = name.split(' ');
  
  if(initials.length > 1) {
    initials = initials.shift().charAt(0) + initials.pop().charAt(0);
  } else {
    initials = name.substring(0, 2);
  }
  
  return initials.toUpperCase();
}

console.log(getInitials(fullName1)) // NW
console.log(getInitials(fullName2)) // JA