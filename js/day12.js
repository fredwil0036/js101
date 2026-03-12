// Day 12 – Find Second Largest Number
// Return the second largest number in an array.

const points = [40, 100, 1, 5, 25, 10];

points.sort(function(a, b) {
  return b - a; // b - a for descending order
});

console.log(points[1]);