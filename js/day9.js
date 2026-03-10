// Day 9 – FizzBuzz
// Print numbers from 1–100:

// divisible by 3 → "Fizz"

// divisible by 5 → "Buzz"

// divisible by both → "FizzBuzz"

function FizzBuzz(nmbr){
    if (nmbr % 3 == 0 && nmbr %5 == 0) {
        console.log('fizzbuzz')
    }else if(nmbr % 3 == 0){
        console.log('fizz')
        
    }else if(nmbr % 5 == 0){
        console.log('buzz')

    }
}

FizzBuzz(3)