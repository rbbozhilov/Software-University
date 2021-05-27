function sumTable() {
    const table = document.getElementsByTagName('tr');
    
    let sum = 0;

    for(let i=1;i<table.length;i++) {

        if(i==table.length) {
            break;
        }
        const td = table[i].getElementsByTagName('td');
        const lastTd = Number(td[td.length-1].textContent);
        sum +=lastTd;



    }

   document.getElementById('sum').textContent = sum;

}