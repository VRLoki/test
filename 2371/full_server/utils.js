const fs = require('fs');

async function readDatabase(path) {
  try {
    const data = await fs.promises.readFile(path, 'utf8');
    const stringData = data.toString();
    const arrayData = stringData.split('\n').slice(1);
    const filteredArrayData = arrayData.filter((line) => line !== '');

    const namesByField = {};
    filteredArrayData.forEach((line) => {
      const parts = line.split(',');
      const firstName = parts[0];
      const field = parts[3];

      if (!namesByField[field]) {
        namesByField[field] = [];
      }
      namesByField[field].push(firstName);
    });

    return namesByField;
  } catch (error) {
    throw new Error('Cannot load the database');
  }
}

module.exports = readDatabase;
