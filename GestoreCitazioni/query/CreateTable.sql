DROP TABLE Authors
DROP TABLE citazioni

CREATE TABLE Authors(
	idAuthor int primary key identity(1,1),
	nome varchar(40) NOT NULL,
	cognome varchar(40) NOT NULL,
	provenienza varchar(40) NOT NULL,
	etaCit int
)

CREATE TABLE citazioni(
	idCit int primary key identity(1,1),
	title varchar(80) NOT NULL,
	descr varchar(6000) NOT NULL,
	comment varchar(6000) NOT NULL,
	lastModiofied datetime NOT NULL,
	typo varChar(40) NOT NULL,
	idAuthor int FOREIGN KEY REFERENCES Authors(idAuthor) NOT NULL
)