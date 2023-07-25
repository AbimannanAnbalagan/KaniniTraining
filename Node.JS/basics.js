var http = require('http');
var today  = require('./mydatetime');

http.createServer(function(req , res)
{
    /*var n1 = 10;var n2 = 20;
    var ans = n1+n2;
    res.write('Answer : ' + ans);
    res.end('\nFinished..');
    res.write('additional');*/
    /*res.writeHead(404 , {'Content-Type':'text/html'})
    res.write('Hello <br>');
    res.end('Finished..');*/
    res.writeHead(202 , {'Content-Type':'text/html'})
    res.write(today.mydatetime());
    res.end('done');
}
).listen(8080);


