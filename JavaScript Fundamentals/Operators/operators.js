let args = ['10'];

function solve(args) {

    let number = +(args[0]);

    if(number % 2 === 0) {
        console.log('even' + ' ' + args[0]);
    }
    else {
        console.log('odd' + ' ' + args[0]);
    }
}

solve(args);