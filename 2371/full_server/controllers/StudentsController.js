const readDatabase = require('../utils');

const path = process.argv[2];

class StudentsController {
  static getAllStudents(request, response) {
    readDatabase(path)
      .then((data) => {
        let responseString = 'This is the list of our students<br/>';
        for (const [field, names] of Object.entries(data)) {
          responseString += `Number of students in ${field}: ${names.length}. List: ${names.join(', ')}<br/>`;
        }
        response.status(200).send(responseString);
      })
      .catch((err) => { response.status(500).send(err.message); });
  }

  static getAllStudentsByMajor(request, response) {
    const { major } = request.params;
    if (major !== 'CS' && major !== 'SWE') response.status(500).send('Major parameter must be CS or SWE');
    readDatabase(path)
      .then((data) => {
        response.status(200).send(`List: ${data[major].join(', ')}`);
      })
      .catch((err) => { response.status(500).send(err.message); });
  }
}

module.exports = StudentsController;
