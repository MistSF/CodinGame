const BEGIN = readline();
const END = readline();

toDay()

function toDay() {
    let splitBegin = BEGIN.split('.');
    let splitEnd = END.split('.');
    
    begDay = parseInt(splitBegin[0]);
    begMonth = parseInt(splitBegin[1]);
    begYear = parseInt(splitBegin[2]);
    
    endDay = parseInt(splitEnd[0]);
    endMonth = parseInt(splitEnd[1]);
    endYear = parseInt(splitEnd[2]);

    totYear = endYear - begYear;

    if (endMonth >= begMonth)
        totMonth = endMonth - begMonth;
    else {
        totMonth = endMonth + (12 - begMonth)
        totYear--
    }
    
    if (endDay >= begDay)
        totDay = endDay - begDay;
    else {
        if (begMonth < 7 && begMonth % 2 === 0)
            totDay = endDay + (30 - begDay)
        else 
            totDay = endDay + (31 - begDay)
        totMonth--;
    }
    
    nbMonth = totMonth + (totYear * 12)
    
    for (let i = 0, curMonth = begMonth, curYear = begYear; i < nbMonth; i++, curMonth++) {
        if (curMonth === 2) {
            totDay += 28
            if ((curYear) % 4 === 0)
                totDay++;
        }
        else if ((curMonth < 7 && curMonth % 2 === 0) || (curMonth > 8 && curMonth % 2 !== 0))
            totDay += 30
        else
            totDay += 31
        if (curMonth === 12) {
            curMonth = 0;
            curYear++;
        }
    }
    printRes()
}

function printRes() {
    valret = '';
    if (totYear > 0) {
        valret += totYear
        if (totYear === 1)
            valret += ' year, '
        else
            valret += ' years, '
    }
    if (totMonth > 0) {
        valret += totMonth
        if (totMonth === 1)
            valret += ' month, '
        else
            valret += ' months, '
    }
    valret += 'total ' + totDay + ' days'
    print(valret)
}