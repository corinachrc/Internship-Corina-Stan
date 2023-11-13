let originalArray=[1,2,3,4,5];
let copiedArray1=originalArray.slice(0,originalArray.length);//o metoda
copiedArray1[0]=10;
console.log("Copied Array:", copiedArray1[0]);
console.log("Original Array:", originalArray[0]);


let copiedArray2=originalArray.concat(originalArray);//alta metoda
copiedArray2[0]=5;
console.log("Copied Array:", copiedArray2[0]);
console.log("Original Array:", originalArray[0]);


let copiedArray3=[...originalArray];//alta metoda
copiedArray3[0]=7;
console.log("Copied Array:", copiedArray3[0]);
console.log("Original Array:", originalArray[0]);
