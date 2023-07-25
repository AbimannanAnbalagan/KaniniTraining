var http = require('http');
var url = require('url');
var fileobj = require('fs');
const { EventEmitter } = require('stream');
var events=require('events');
http.createServer(function (req, res) 
{
    /*
    var fileobj = require('fs');
var readstream= fileobj.createReadStream('./basics.js');
readstream.on('open',function(){
 console.log('The file is open..');
});
*/

//Event handler
    var myEventHandler=function(){
        console.log('I Scored 200');
    }
    var eventEmiter = new events.eventEmiter();
//assign event handler
    EventEmitter.on('Results out',myEventHandler); 
    EventEmitter.emit('Results out');

 }
).listen(8080);