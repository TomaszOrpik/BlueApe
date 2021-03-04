const fs = require('fs');

const content = '<div>Some test Content</div>';

const pageData = `function About() {
    return ${content}
  }
  
  export default About`;


fs.writeFileSync('output.js', pageData, function (err) {
    if (err) throw err;
    console.log('Saved!');
});



///must be open with node createPages.js  ///create exe from this file that will connect to database 
//and create new page