CREATE DATABASE db_wyr;
USE db_wyr;

CREATE TABLE Questions
(
	qID INT NOT NULL IDENTITY,
	qC_1 NVARCHAR(30) NOT NULL,
	qC_2 NVARCHAR(30) NOT NULL,
	qA_1 INT NOT NULL DEFAULT 0,
	qA_2 INT NOT NULL DEFAULT 0,

	CONSTRAINT pk_qid PRIMARY KEY(qID)
);


INSERT INTO Questions(qC_1, qC_2) VALUES
('Eat bogger', 'Eat wax'),
('Player football in real life', 'Play football in a video game'),
('Cut off your right hand', 'Cut off your left hand'),
('Learn C#', 'Learn Java'),
('Live in france', 'Live in germany');

SELECT * FROM Questions;