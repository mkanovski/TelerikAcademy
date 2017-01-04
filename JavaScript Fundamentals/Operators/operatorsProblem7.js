function solve(args) {

    let number = +(args[0]);

    if (number <= 0){
        console.log('false');
    }
    else{
        if(isPrime(number)){
            console.log('true');
        }
        else{
            console.log('false');
        }
    }

    function isPrime(value) {
    for(let i = 2; i < value; i++) {
        if(value % i === 0) {
            return false;
        }
    }
    return value > 1;
}
}



solve(['15'])