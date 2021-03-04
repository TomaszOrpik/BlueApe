const {exec} = require('pkg'); 
    async function create() { await exec(['./builders/yolo/create.js']) }; 
    module.exports.create = create()