function solve(args) {
    var input = +args;
    var output = '';
    
    for (var index = 1; index <= input; index++) {
        output  += String(index) + ' ';
        
    }
    
    output = output.trim();
    console.log(output);
}