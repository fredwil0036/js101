// Day 15 – Count Word Frequency
// Count how many times each word appears in a sentence.

const word = "one two one every have a low one";

const aWord = word.split(' ');
const frequency = {};

for (let i = 0; i < aWord.length; i++) {
    const currentWord = aWord[i];

    if (frequency[currentWord]) {
        frequency[currentWord]++;
    } else {
        frequency[currentWord] = 1;
    }
}

console.log(frequency);