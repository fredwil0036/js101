// Day 13 – Capitalize Words
// Capitalize the first letter of each word in a sentence.
let word = "hellow world kano sa"

function upperCase(val){
    return val.charAt(0).toUpperCase() + val.slice(1);
}
function CapitalizeWord(str){
    let splitWord = str.split(" ");

    for(let i = 0; i < splitWord.length; i++){
        splitWord[i] = upperCase(splitWord[i]);
    }

    return splitWord.join(' ')
}
    
console.log(CapitalizeWord(word))