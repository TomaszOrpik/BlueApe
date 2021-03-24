const express = require('express');
const bodyParser = require('body-parser');
const fs = require('fs-extra');
const cors = require('cors');
const app = express();
const jsonParser = bodyParser.json();
const port = 9000;
const fileupload = require('express-fileupload');
const AdmZip = require('adm-zip');
const MongoClient = require('mongodb').MongoClient;

app.use(cors());
app.use(fileupload());
app.use(jsonParser);
app.use( express.urlencoded({ extended: true }));
app.use(express.static(__dirname));

app.get('/', function (req, res) {
    res.sendFile(__dirname + '/index.html')
});

///Endpoint to download json
app.get('/config/:name', async function (req, res) {
  let url;
  if (app.settings.env === "development")
     url = "mongodb://localhost:27017/";
  else url = "connection string for prod env";

  MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    var dbo = db.db('BlueApeDB');
    const name = req.params.name.replace(/%20/g, " ");
    dbo.collection(name).findOne({}, function(err, result) {
      if (err) throw err;
      const dir = `./Downloads/${name}`;
      if (!fs.existsSync(dir)) fs.mkdirSync(dir);
      fs.writeFileSync(`${dir}/BlogDocument.json`, JSON.stringify(result, null, 2));
      res.download(`${dir}/BlogDocument.json`, function(error) {
        console.log(error);
      });
      res.status(200);
      db.close();
    });
  });
});
///Endpoint to download page with backend as json
app.get('/staticPage/:name', async function (req, res) {
  let url;
  if (app.settings.env === "development")
     url = "mongodb://localhost:27017/";
  else url = "connection string for prod env";

  const name = req.params.name.replace(/%20/g, " ");
  const tempDir = `./${name}`;
  if (!fs.existsSync(tempDir)) fs.mkdirSync(tempDir);
  console.log('folder created');
  /// move example folder
  fs.copySync('./blogtemplate', `${tempDir}`, {overwrite: true, recursive: true, force: true}, function(err) {
    if (err) console.log(err);
    else console.log(tempDir, 'created');
  });
  sleep(1000);
  MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    var dbo = db.db('BlueApeDB');
    dbo.collection(name).findOne({}, function(err, result) {
      if (err) throw err;
      fs.writeFileSync(`${tempDir}/BlogDocument.json`, JSON.stringify(result, null, 2));
      console.log('json created');
      /// add blogData file
      fs.writeFileSync(`${tempDir}/pages/api/blogData.js`,
      ` import blogDocument from '../../BlogDocument.json';

       export default (req, res) => {
         res.status(200).json(blogDocument)
       }`, function (err) {
         if (err) throw err;
       })
      /// pack to zip
      const targetDir = `./Downloads/${name}`;
      if (!fs.existsSync(targetDir)) fs.mkdirSync(targetDir);
       const file = new AdmZip();
       file.addLocalFolder(`${tempDir}`, name);
       fs.writeFileSync(`${targetDir}/${name}-static.zip`, file.toBuffer());

       fs.rmSync(tempDir, { recursive: true, force: true });
      res.download(`${targetDir}/${name}-static.zip`, function (error) {
        console.log(error);
      });
      res.status(200);
      db.close();
    });
  });
});
///Endpoint to download page with backend from mongo DB
app.get('/dynamicPage/:name', async function (req, res) {
  let url;
  if (app.settings.env === "development")
    url = "mongodb://localhost:27017/";
  else url = "connection string for prod env";

  const name = req.params.name.replace(/%20/g, " ");
  const tempDir = `./${name}`;
  if (!fs.existsSync(tempDir)) fs.mkdirSync(tempDir);
  console.log('folder created');
  /// move example folder
  fs.copySync('./blogtemplate', `${tempDir}`, { overwrite: true, recursive: true, force: true }, function (err) {
    if (err) console.log(err);
    else console.log(tempDir, 'created');
  });
  sleep(1000);

  /// add blogData file
  fs.writeFileSync(`${tempDir}/pages/api/blogData.js`,
    `const MongoClient = require('mongodb').MongoClient;

      export default (req, res) => {
        const url = "${url}";
        const dbName = 'BlueApeDB'
        const collectionName = '${name}';
        MongoClient.connect(url, function(err, db) {
          if (err) throw err;
          var dbo = db.db(dbName);
          dbo.collection(collectionName).findOne({}, function(err, result) {
            if (err) throw err;
            res.status(200).json(result);
          })
        })
      }`, function (err) {
    if (err) throw err;
  })
  /// pack to zip
  const targetDir = `./Downloads/${name}`;
  if (!fs.existsSync(targetDir)) fs.mkdirSync(targetDir);
  const file = new AdmZip();
  file.addLocalFolder(`${tempDir}`, name);
  fs.writeFileSync(`${targetDir}/${name}-dynamic.zip`, file.toBuffer());

  fs.rmSync(tempDir, { recursive: true, force: true });
  res.download(`${targetDir}/${name}-dynamic.zip`, function (error) {
    console.log(error);
  });
  res.status(200);
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
//helpers
function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
  }