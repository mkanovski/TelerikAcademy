function solve(args) {

    let a = +(args[0]);
    let b = +(args[1]);
   let container;

   if(a > b){
       container = a;
       a = b;
       b = container;
   }

   console.log(a + ' ' + b);
}