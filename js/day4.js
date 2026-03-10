
// Day 4 – Reverse a String
// Create a function that reverses a string.
// Example: "hello" → "olleh"
function reversesString(str){
    return str.split('').reverse().join('');
}

console.log(reversesString("hello"));