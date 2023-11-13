function squareOddNumbers(numbers) {
    let squaredOddNumbersArray=[];
    numbers.forEach(number => {  
      
      if (number % 2 != 0) {
       
        squaredOddNumbersArray.push(number*number);
      } 
    });
  
    return squaredOddNumbersArray;
  }
  
  // Example usage:
  let inputArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];
  let resultArray = squareOddNumbers(inputArray);
  
  console.log("Original Array:", inputArray);
  console.log("Squared Odd Numbers Array:", resultArray);
  
  
  
  
  
  
  