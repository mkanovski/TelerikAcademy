function solve(args) {

    let number = +(args[0]);

    if(number % 5 === 0 && number % 7 === 0) {
        console.log('true' + ' ' + args[0]);
    }
    else {
        console.log('false' + ' ' + args[0]);
    }
}

solve(['35']);