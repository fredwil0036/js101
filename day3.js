// Day 3 – Even or Odd Checker
// Write a program that checks if a number is even or odd.

function EvenOrOddsChecker(a){
    let rem = a % 2;
    if(rem == 0){
     result = "even"
    }else{
     result = "odd"
    }
    return result
}

console.log(EvenOrOddsChecker(3))