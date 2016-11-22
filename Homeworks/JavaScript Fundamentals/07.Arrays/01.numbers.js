function solve(args) {
    var n = +args[0],
        arr = [];
        
    for(i = 0; i < n; i += 1) {
        
        arr[i] = parseInt(i * 5);
        console.log(arr[i]);
    }
}