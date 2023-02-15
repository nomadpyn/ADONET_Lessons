use Library
CREATE TABLE Authors
(
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL
)

use Library
CREATE TABLE Books
(
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	AuthorId INT NOT NULL,
	FOREIGN KEY (AuthorId) REFERENCES Authors(id),
	Title NVARCHAR(100) NOT NULL,
	Price INT,
	Pages INT
)