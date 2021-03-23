// import blogDocument from '../../BlogDocument.json';

// export default (req, res) => {
//   res.status(200).json(blogDocument)
// }


const MongoClient = require('mongodb').MongoClient;

export default (req, res) => {
  const url = "mongodb://localhost:27017/";
  const collectionName = 'Blue Ape Template';
  MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    var dbo = db.db('BlueApeDB');
    dbo.collection(collectionName).findOne({}, function(err, result) {
      if (err) throw err;
      res.status(200).json(result);
    })
  })
  res.status(200).json(data);
}
