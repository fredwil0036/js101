// Day 6 – Find Largest Number in Array
// Given an array of numbers, return the largest value.


function findLargest(nbr){

    let highestNumber = nbr[0];
    for(let i = 1 ; i  < nbr.length ; i++){
        if (nbr[i] > highestNumber) {
                highestNumber = numbers[i];
        }
    }
    console.log(highestNumber)
}

const numbers = [1,3,4,5,10,9];

findLargest(numbers)
