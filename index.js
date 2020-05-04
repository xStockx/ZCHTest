var express = require('express');
var app = express();
var os = require('os')
app.use('/css',express.static(__dirname+'/css'));
app.use('/img',express.static(__dirname+'/img'));
console.log(__dirname);
app.get('/', function (req, res) {
  res.sendFile(__dirname+'/index.html');
});
app.get('/server', function (req, res) {
  data = {
    nombreServer : 'PRBDMF207',
    sistemaOperativo : 'Windows Server 2012',
    pod : os.hostname(),
  };
  res.json(data);
});
app.listen(8080, function () {
  console.log('Example app listening on port 8080!');
});

