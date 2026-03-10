// Day 7 – Count Vowels
// Count how many vowels (a, e, i, o, u) are in a string.

function countVowel(str){
    let count = 0;
    const splitArray = str.split('');
    let regex = /^[aeiouAEIOU]$/;

    // 1st loop each
    for(let i = 0 ; i < splitArray.length; i++){
        if (regex.test(splitArray[i])) {
            count++
        }
    }

    console.log(count)
}
countVowel('adobong pusit');