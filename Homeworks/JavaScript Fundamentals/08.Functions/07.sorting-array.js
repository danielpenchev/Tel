function solve(args) {
    var n = +args[0];
    arr = args[1].split(' ');

    console.log(SortArray(arr).join(' '));

    function SortArray(array) {
        array = SortArrayByDescending(array);
        return array.reverse();
    }

    function SortArrayByDescending(array) {
        var i,
            max,
            index,
            keeper;

        for (i = 0; i < array.length; i += 1) {
            max = GetMax(i,array);
            index = array.indexOf(max,i);

            keeper = array[i];
            array[i] = max;

            array[index] = keeper;
        }
        return array;
    }
    function GetMax(k, array) {
        var i,
        max = -Number.MAX_VALUE;

        for(i = k; i < array.length; i += 1) {
            if(+array[i] > max) {
                max = array[i];
            }
        }
        return max;
    }
}