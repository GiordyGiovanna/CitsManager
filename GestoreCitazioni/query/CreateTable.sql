CREATE TABLE Authors(
	idAuthor int primary key identity(1,1),
	nome varchar(40) NOT NULL,
	cognome varchar(40) NOT NULL,
	provenienza varchar(40) NOT NULL,
	etaCit int
)


CREATE TABLE citazioni(
	idCit int primary key identity(1,1),
	title varchar(20) NOT NULL,
	descr varchar(2000) NOT NULL,
	dataAggiunta datetime NOT NULL,
	idAuthor int FOREIGN KEY REFERENCES Authors(idAuthor) NOT NULL
)