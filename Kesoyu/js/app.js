//init mongodb

const mongo = require('mongodb');

//config database

const url = 'mongodb://localhost:27017';
const clinet = new mongo.MongoClient(url);

//connect with database

async function main() {
	await clinet.connect();
    console.log('connected to database')
    const db = await clinet.db("test");
    const workers = await db.collection("pracownicy");
    const lista_pracownikow = await workers.find({}).toArray();
    console.table(lista_pracownikow)
}

// closed connection

main()
    .finally(() => clinet.close(console.log("connection closed")));
