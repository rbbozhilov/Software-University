class Request {


    response = undefined;
    fulfilled = false;

    constructor(method,uri,version,message) {
        this.method = method;
        this.message = message;
        this.uri  = uri;
        this.version = version; 
    }
}

let myData = new Request('GET', 'http://google.com', 'HTTP/1.1', '')
console.log(myData);
