// Day 5 – Palindrome Checker
// Check if a word reads the same forward and backward.
// Example: "racecar" → palindrome.

function checkPalinrome(a){
    const reveseStr = a.split('').reverse().join('');

    if(a == reveseStr){
        return `${a} is palindrome`
    }else{
        return `${a} is not palindrome`
    }
}

console.log(checkPalinrome('racecas'))