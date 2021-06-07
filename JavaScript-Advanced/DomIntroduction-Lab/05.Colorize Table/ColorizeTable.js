function colorize() {
    const elementsofRows = document.querySelectorAll('table tr');
    for(let i=1;i<elementsofRows.length;i +=2) {
        elementsofRows[i].style.backgroundColor = 'teal';
    }
   


}
