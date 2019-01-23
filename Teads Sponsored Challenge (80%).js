class personne {    
    constructor(id) {
        this.id = id;
        this.contact = [];
    }
    
    addContact(nContact) {
        if (!this.contact.includes(nContact))
            this.contact.push(nContact);
    }
    
    doyouseethat(idSender) {
        let res = 0;
        let max = 0;
        this.contact.forEach((e) => {
            if (e.id !== idSender && e.contact.length > 1) {
                res = e.doyouseethat(this.id)
                if (max === -1)
                    max = res;
                if (max < res)
                    max = res;
            }
        });
        return max + 1;
    }
}

let targets = [];
let targetsId = [];

const n = parseInt(readline()); // the number of adjacency relations

for (let i = 0; i < n; i++) {
    var inputs = readline().split(' ');
    const xi = parseInt(inputs[0]); // the ID of a person which is adjacent to yi
    const yi = parseInt(inputs[1]); // the ID of a person which is adjacent to xi
    
    xId = targetsId.indexOf(xi);
    yId = targetsId.indexOf(yi);
    
    if (xId === -1) {
        targets.push(new personne(xi));
        xId = targets.length-1;
        targetsId.push(xi);
    }
    if (yId === -1) {
        targets.push(new personne(yi));
        yId = targets.length-1;
        targetsId.push(yi);
    }
    targets[xId].addContact(targets[yId])
    targets[yId].addContact(targets[xId])
}

let valret = 0;
let min = -1;

targets.forEach((e) => {
    if (e.contact.length > 1) {
        valret = e.doyouseethat(e.id);
        if (min === -1)
            min = valret
        if (valret < min)
            min = valret
    }
})

print(min)