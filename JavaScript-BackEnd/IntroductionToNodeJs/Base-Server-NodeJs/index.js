const http = require('http');


const homePage = `<h1> Welcome to Home page</h1> <div>Some basic node.js server..</div> <a href = "/aboutpage">About</a>`;

const aboutpage = `<h1> Welcome to About page</h1> <div>Contact us on ******** </div><a href = "/"> Home </a>`;

const routes = {
    "/": homePage,
    "/aboutpage" : aboutpage
};

const server = http.createServer((request,response) => {
    
    const url = new URL(request.url, `http://${request.headers.host}`);


    const currentPage = routes[url.pathname];

    if(currentPage != undefined){
        response.write(currentPage);
    }else{
        response.statusCode = 400;
        response.write("not found");
        response.end();
    }

    
});

server.listen(3000);

function html(body){
    return body;
}