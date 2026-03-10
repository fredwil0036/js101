// Day 8 – Factorial Calculator
// Calculate the factorial of a number.
// Example: 5! = 120.

function factorial(nmr){
    let total = 1;
    for( let i = 1; i <= nmr; nmr--){
        total = total * nmr
    }
    console.log(total)
}
factorial(6)