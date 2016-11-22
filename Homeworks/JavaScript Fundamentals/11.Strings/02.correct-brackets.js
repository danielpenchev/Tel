function CountBrackets(str) {
    let input = String(str);
    let openBracket = 0;
    let closeBracket = 0;

    let index = input.indexOf('(');
    while(index >= 0) {
        openBracket += 1;
        index = input.indexOf('(', index + 1);
    }

    index = input.indexOf(')');
    while(index >= 0) {
        closeBracket += 1;
        index = input.indexOf(')', index + 1);
    }

    if(openBracket === closeBracket) {
        return true;
    } else {
        return false;
    }
}