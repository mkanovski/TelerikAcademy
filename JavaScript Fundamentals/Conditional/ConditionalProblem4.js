function solve(args) {
    
    let a = +(args[0]);
    let b = +(args[1]);
    let c = +(args[2]);

    let max;

    if(b > a){
        if(c > b){
            max = c;
        }
        else{
            max = b;
        }
    } 
    else{
        if (a > c){
            max = a;
        }
        else{
            max = c;
        }
    }

    console.log(max);
}