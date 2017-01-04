function solve(args) {

    let width = +(args[0]);
    let height = +(args[1]);

    let area = width * height;
    let perimeter = 2*width + 2*height;
    area = (Math.round(area * 100) / 100).toFixed(2);
    perimeter = (Math.round(perimeter * 100) / 100).toFixed(2);
    
    console.log(area + ' ' + perimeter);
}

solve(['10', '5'])