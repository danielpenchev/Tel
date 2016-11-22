function solve(args) {
    var n = +args,
        i, j, len,
        isPrime = false,
        array = [];
        
    for(i = n; i >= 2; i -= 1) {
        len = Math.sqrt(i);
        isPrime = true;
        for(j = 2; j <= len; j += 1) {
            if(i % j === 0) {
                isPrime = false;
            }
        }
        if(isPrime) {
            console.log(i);
            return;
        }
    }
}