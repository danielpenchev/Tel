function solve(args) {
    var input = (args[0] + '').split('\n'),
        found = false,
        len = 0;
        
    var arrayA = input[0],
        arrayB = input[1];
        
    if(arrayA.length >= arrayB.length) {
        len = arrayB.length;
    } else {
        len = arrayA.length;
    }
    
    for(var i = 0; i < len; i += 1) {
        if(arrayA[i] < arrayB[i]) {
            console.log('<');
            found = true;
            break;
        }
        else if (arrayA[i] > arrayB[i]) {
            console.log('>');
            found = true;
            break;
        }
    }
    
    if(!found) {
        if(arrayA.length > arrayB.length) {
            console.log('>');
        }
        else if (arrayA.length === arrayB.length) {
            console.log('=');
        }
        else {
            console.log('<');
        }
    }
}