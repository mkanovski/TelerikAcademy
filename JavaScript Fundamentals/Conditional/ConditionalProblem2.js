function solve(args) {
    
    let a = +(args[0]);
    let b = +(args[1]);
    let c = +(args[2]);

    let result = checkSign(a, b, c);

    console.log(result);

function checkSign(x, y, z){

    if(x === 0|| y === 0 || z === 0){
        return 0;
    }

    if (x>0 && y>0 && z>0)  
{  
       return "+";  
}  
else if (x<0 && y<0 && z>0)  
        {  
          return "+";  
        }  
        else if (x>0 && y<0 && z<0)  
        {  
          return "+";  
        }  
        else if (x<0 && y>0 && z<0)  
        {  
          return "+";  
        }  
        else  
        {  
          return "-";  
        }  


}   
}