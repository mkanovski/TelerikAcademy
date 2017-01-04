function solve(args) {

    let number = +(args[0]);

    let numberString = number.toString(2);

    numberString = numberString.charAt(numberString.length - 4);

    if (numberString === ''){
        numberString = '0';
    }
    console.log(numberString);
}

solve(['4356'])