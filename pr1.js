// Citeste un vector de la tastatura.Verifica c=de cate ori apare o valore in vectorul introdus
const n = parseInt(prompt("Enter the number of values:"));
const vector = [];
for (let i = 0; i < n; i++) {
  vector.push(parseInt(prompt(`Enter value ${i + 1}:`)));
}
const target = parseInt(prompt("Enter the target number:"));

// numara numarul de aparitii 
const count = countOccurrences(vector, target);
function countOccurrences(arr, target) {
  let count = 0;
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] === target) {
      count++;
    }
  }
  return count;
}
alert(`${target} appears ${count} times in the vector.`);
;