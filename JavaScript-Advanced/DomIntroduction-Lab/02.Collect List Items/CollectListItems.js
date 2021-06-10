function extractText() {
    const elements = document.getElementsByTagName('li');
    for(let element of elements) {
        document.getElementById('result').textContent +=element.textContent + '\n';
    }
}

