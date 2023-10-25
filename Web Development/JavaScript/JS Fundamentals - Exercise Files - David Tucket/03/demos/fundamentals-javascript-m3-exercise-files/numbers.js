//Define number values
let num1 = 6;
console.log(num1);
//outputs 1.56e+21 //e+21 means there is 21 0s to the right of 1.56
let num2 = 1560000000000000000000000;
console.log(num2);
//outputs -2.1e-18 //e-18 means 18 0s to the left of -2.1
let num3 = -0.00000000000000000000021;
console.log(num3);
//creating numbers with e-notation
let num4 = 1.2e+10;
console.log(num4);

//How big and small can we get with the number type
console.log(`Minimum value: ${Number.MIN_VALUE}`);
console.log(`Minimum safe integer: ${Number.MIN_SAFE_INTEGER}`);
console.log(`Maximum value: ${Number.MAX_VALUE}`);
console.log(`Maximum safe integer: ${Number.MAX_SAFE_INTEGER}`);

//Creating BigInt's
let bigInt1 = 1n;
//0 and underscores are ignored and are used to help read big numbers.
let bigInt2 = 1_560_000_000_000_000_000_000n;

