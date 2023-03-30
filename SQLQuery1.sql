CREATE TABLE clients(
id int not null primary key identity,
name varchar(100) not null,
email varchar (150) not null unique,
phone varchar (20) null,
address varchar(100) null,

);


