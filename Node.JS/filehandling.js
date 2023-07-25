var http = require('http');
var fileobj = require('fs');

http.createServer(function(req , res){
    /*fileobj.open('sample.txt','w',function(err,file){
        if(err)throw err;
        console.log('saved');
    });*/
    /*fileobj.writeFile('sample.txt' , 'one line written' , function(err){
        if(err) throw err;
        console.log('written');
    })*/
    /*
    fileobj.readFile('sample.txt' , function(err , data){
        res.writeHead(200,{'Content-type' : 'text/html'});
        res.write(data);
        return res.end();
    })*/
    /*
    fileobj.appendFile('sample.txt' , '\none line appended' , function(err){
        if(err) throw err;
        console.log('appended');
    })*/
    /*
    fileobj.rename('sample.txt' , 'name.txt' , function(err){
        if (err) throw err;
        console.log('file renamed');
    })*/
    /*fileobj.unlink('sample2.txt' , function(err){
        if (err) throw err;
        console.log('file deleted');
    })*/
    fileobj.readFile('sample.html' , function(err , data){
        res.writeHead(200,{'Content-type' : 'text/html'});
        res.write(data);
        console.log('file red');
        return res.end();
    })
}).listen(9000);