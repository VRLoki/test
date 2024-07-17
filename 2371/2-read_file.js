const fs = require('fs');

function countStudents(path) {
  let data = '';

  try {
    data = fs.readFileSync(path, 'utf8');
  } catch (error) {
    throw new Error('Cannot load the database');
  }

  const array = data.split('\n').slice(1).filter((line) => line !== '');
  console.log(`Number of students: ${array.length}`);

  const namesbyField = {};
  array.forEach((line) => {
    const entry = line.split(',');
    const name = entry[0];
    const field = entry[3];

    if (!namesbyField[field]) namesbyField[field] = [];
    namesbyField[field].push(name);
  });

  const fields = Object.keys(namesbyField);
  for (const field of fields) {
    const names = namesbyField[field];
    const count = names.length;
    const list = names.join(', ');
    console.log(`Number of students in ${field}: ${count}. List: ${list}`);
  }
}

module.exports = countStudents;
