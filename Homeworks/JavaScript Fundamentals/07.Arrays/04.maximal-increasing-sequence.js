function solve(args) {
    var array = (args[0] + '').split('\n').map(Number),
        max = 0,
        counter = 1,
        prev = array[0],
        element;
        
    for(i = 1; i < array.length; i += 1) {
        element = array[i];
        
        if(element > prev) {
            counter += 1;
        } else {
            if(counter > max) {
                max = counter;
            }
            
            counter = 1;
        }
        
        prev = element;
    }
    
    if(counter > 1) {
        if(counter > max) {
            max = counter;
        }
    }
    
    console.log(max);
}