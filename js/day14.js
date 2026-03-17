
// Day 14 – Sort Array
// Sort an array of numbers in ascending order.

let number= [1,3,4,5,6,8,10,9]

// number.sort(function(a,b){
//     if (a > b) {
//         return 1
//     }else if (a < b) {
//         return -1
//     }else{
//         return 0;
//     }

// })


function swap(arr, i, j){
    let temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

function sortAscending(arr){
    for(let i = arr.length - 1; i > 0; i--){
        for(let j = 0; j < i; j++){
            if(arr[j] > arr[j + 1]){
                swap(arr, j, j + 1)
            }
        }
    }
    return arr;
}


console.log(sortAscending(number))
