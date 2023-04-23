//Primele elemente din seria fibonacii intr-un vector introdus

// citeste numerele generate
const n = parseInt(prompt("Enter the number of terms:"));

// genereaza seria fibonacci intr-un vector
const fib = fibonacci(n);
function fibonacci(n) {
  const fib = [0, 1];
  for (let i = 2; i < n; i++) {
    fib[i] = fib[i - 1] + fib[i - 2];
  }
  return fib.slice(0, n);
}


// Afiseaza vectorul
alert(`The first ${n} terms of the Fibonacci sequence are: [${fib.join(", ")}].`);
