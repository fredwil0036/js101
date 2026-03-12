// Day 11 – Remove Duplicates from Array
// Create a function that removes duplicate values from an array.

function removeDuplicate(data){
    for(let i = 0; i < data.length; i++){
        for(let j = i + 1; j < data.length; j++){
            if(data[i] === data[j]){
                data.splice(j, 1);
                j--;
            }
        }
    }
    console.log(data);
}

const data = [1,1,22,2,2,3,4,5,5];
removeDuplicate(data);