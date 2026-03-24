// Day 17 – Find Missing Number
// Given a sequence of numbers, find the missing number.

function findMissingNumbers(arr) {
  let missing = [];
  
  let min = Math.min(...arr);
  let max = Math.max(...arr);

  let set = new Set(arr); // faster lookup

  for (let i = min; i <= max; i++) {
    if (!set.has(i)) {
      missing.push(i);
    }
  }

  return missing;
}

let arr = [1, 2, 4, 6, 7, 8, 10];
console.log(findMissingNumbers(arr));