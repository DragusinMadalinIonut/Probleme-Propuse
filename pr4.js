//cel mai mare divior comun intr-un array
// citeste numerele din array
const n = parseInt(prompt("Enter the number of values:"));
const numbers = [];
for (let i = 0; i < n; i++) {
  numbers.push(parseInt(prompt(`Enter number ${i + 1}:`)));
}

// calculeaza cel mai mare divizor comun
const result = cmmdc(numbers);
function cmmdc(arr) {
  const n = arr.length;
  let result = arr[0];
  for (let i = 1; i < n; i++) {
    result = cmmdcTwoNumbers(result, arr[i]);
    if (result === 1) {
      return 1;
    }
  }
  return result;
}

function cmmdcTwoNumbers(a, b) {
  if (b === 0) {
    return a;
  }
  return cmmdcTwoNumbers(b, a % b);
}


// Arata rezultatul
alert(`The greatest common divisor of the numbers is ${result}.`);