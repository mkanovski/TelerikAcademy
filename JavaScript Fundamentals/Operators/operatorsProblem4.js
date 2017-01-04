function solve(args) {

   let thirdDigit = String(args[0]);
   thirdDigit = thirdDigit.charAt(thirdDigit.length - 3);   

   if(thirdDigit === '7'){
       console.log('true');
   }
   else{
       if (thirdDigit === ''){
           thirdDigit = '0';
       }
       console.log('false' + ' ' + thirdDigit);
   }
}

solve(['435782'])