function solve(args) {
    var input = (args + "").split("\n").map(Number), //сплитваме
        checked = [],
        i, j, 
        counter = 0,
        max = 0,
        maxNum = 0;
        
    input.splice(0, 1);
    
    for(i = 0; i < input.length; i += 1) {
        if(checked.indexOf(input[i]) >= 0) {
            continue;
        }
        
        for(j = 0; j < input.length; j += 1) {
            if(input[j] === input[i]) {
                counter += 1;
            }
        }
        
        if(max < counter) {
            max = counter;
            maxNum = input[i];
        }
        
        counter = 0;
        checked.push(input[i]);
    }
    
    console.log(maxNum + ' (' + max + ' times)');
}