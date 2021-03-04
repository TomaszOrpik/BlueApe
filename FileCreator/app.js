const express = require('express');
const bodyParser = require('body-parser');
const { exec } = require('pkg');
const path = require('path');
const fs = require('fs');
const { response } = require('express');
const cors = require('cors');
const app = express();
const jsonParser = bodyParser.json();
const urlencodedParser = bodyParser.urlencoded({ extended: false });
const base64Img = require('base64-img');
const multer = require('multer');
const { RSA_NO_PADDING } = require('constants');
const port = 9000;
const fileupload = require('express-fileupload');


///musi pobierać dane z mongoDB i generować ogromny plik budujący repo
const createFileTheme = `
const fs = require('fs');

const content = '<div>Some test Content</div>';

const pageData = \`function About() {
    return \${content}
  }
  
  export default About\`;


fs.writeFileSync('output.js', pageData, function (err) {
    if (err) throw err;
    console.log('Saved!');
});
`;


app.use(cors());
app.use(fileupload());
app.use(jsonParser);
app.use( express.urlencoded({ extended: true }));
app.use(express.static(__dirname));

///add create file function that will draw whole Page from database Creator
app.get('/', function (req, res) {
  res.sendFile(__dirname + '/index.html')
});


app.get('/:name', async function (req, res) {
  const name = `./${req.params.name}.js`;
    fs.writeFileSync(name, createFileTheme);
    await sleep(100);
    await exec([name, '--windows']);
    await sleep(100);
    fs.unlinkSync(path.join(__dirname+'\\'+req.params.name+'-linux'));
    fs.unlinkSync(path.join(__dirname+'\\'+req.params.name+'-macos'));
    fs.unlinkSync(`./${req.params.name}.js`);
    res.download(__dirname + `/${req.params.name}-win.exe`, req.params.name+'-win.exe');
});
///End point to create logo image on server
app.post('/saveImage', async function (req, res) {
  const fileName = req.body.fileName;
  const base64DataRaw = req.body.base64File;
  base64Data = base64DataRaw.replace(/^data:image\/png;base64,/, "");

  fs.writeFile(`logos/${fileName}`, base64Data, 'base64', function(err) {
  if (err) console.log(err);
});
  let imageUrl = `${req.protocol}://${req.headers.host}/logos/${fileName}`;
  res.statusCode = 200;
  res.json({"logoUrl": imageUrl});
  res.message = 'File uploaded';
  res.end();
});
///End point to delete logo image from server
app.delete('/deleteImage/:name', async function (req, res) {
  const filePath = `./logos/${req.params.name}`;
  fs.unlink(filePath);
  res.statusCode = 200;
  res.message = 'File deleted';
  res.end;
});
// Endpoint to add jpg image to server
app.post('/saveJpgImage', async function (req, res) {
  const fileName = req.body.fileName;
  const base64DataRaw = req.body.base64File;
  base64Data = base64DataRaw.replace(/^data:image\/png;base64,/, "");

  fs.writeFile(`images/${fileName}`, base64Data, 'base64', function(err) {
  if (err) console.log(err);
});
  let imageUrl = `${req.protocol}://${req.headers.host}/images/${fileName}`;
  res.statusCode = 200;
  res.json({"imageUrl": imageUrl});
  res.message = 'File uploaded';
  res.end();
});
// Endpoint to deleted jpg image from server
app.delete('/deleteJpgImage/:name', async function (req, res) {
  const filePath = `./images/${req.params.name}`;
  fs.unlink(filePath);
  res.statusCode = 200;
  res.message = 'File deleted';
  res.end;
});

app.listen(port, () => console.log(`Server started at port ${port}`));

function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
  }