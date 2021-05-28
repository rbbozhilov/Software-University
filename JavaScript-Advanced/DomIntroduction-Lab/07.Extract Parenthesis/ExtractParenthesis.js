function extract(content) {
    let text = document.getElementById(content).textContent;

    const regex = /\((.+?)\)/gm;
    let match = regex.exec(text);
    let finalResult = [];

    while(match != null) {

        finalResult.push(match[1]);
        match = regex.exec(text);

    }

    return finalResult.join('; ');
}