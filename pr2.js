//Se citeşte un număr natural N. Se citesc N numere într-un
//vector a. Să se calculeze ante-maximul din vector ( al doilea număr ca
//mărime din vector, după maxim). Exemplu:
//a=[-1,-1,10,5,7,6] , ante-maximul este 7 (maximul este 10).
//După citirea vectorului, pentru a afla ante-maximul, se va face
//o singură parcurgere a vectorului.
//Indicaţie:
//Se va iniţializa maximul cu maximul dintre primele două
//numere din vector şi ante-maximul cu minimul dintre primele două
//numere din vector.


// citim vectorul
const n = parseInt(prompt("Enter the number of values:"));
const vector = [];
for (let i = 0; i < n; i++) {
  vector.push(parseInt(prompt(`Enter value ${i + 1}:`)));
}

// calculare ante-maxim vector
const anteMax = getAnteMax(vector);
function getAnteMax(arr) {
  let max = Math.max(arr[0], arr[1]);
  let anteMax = Math.min(arr[0], arr[1]);
  for (let i = 2; i < arr.length; i++) {
    if (arr[i] > max) {
      anteMax = max;
      max = arr[i];
    } else if (arr[i] > anteMax && arr[i] < max) {
      anteMax = arr[i];
    }
  }
  return anteMax;
}


// Afisare Rezultat
alert(`The ante-maximum of the vector is ${anteMax}.`);