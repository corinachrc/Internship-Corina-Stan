function reverseString(inputString) {
    let reversedString = inputString.split('').reverse().join('');
    
    return reversedString;
  }
  
  
  let originalString = "Buna Vali!";
  let reversedResult = reverseString(originalString);
  
  
  console.log(reversedResult);