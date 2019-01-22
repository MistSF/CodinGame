const expression = readline();

par = 0;
cro = 0;
acc = 0;
last = '';

valret = 'true';

for (let i = 0; i < expression.length; i++) {
    switch(expression[i]) {
        case '(':
            par++;
            break;
        case ')':
            par--;
            break;
        case '[':
            cro++;
            break;
        case ']':
            cro--;
            break;
        case '{':
            acc++;
            break;
        case '}':
            acc--;
            break;
    }
    if (par < 0 || cro < 0 || acc < 0) {
        valret = 'false';
        break;
    }
    if (last === '(' && (expression[i] === '}' || expression[i] === ']')) {
        valret = 'false';
        break;
    }
    last = expression[i]
}

if (par != 0 || cro != 0 || acc != 0)
    valret = 'false'

print(valret);