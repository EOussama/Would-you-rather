CREATE DATABASE db_wyr;
USE db_wyr;

CREATE TABLE Questions
(
	qID INT NOT NULL IDENTITY,
	qC_1 NVARCHAR(100) NOT NULL,
	qC_2 NVARCHAR(100) NOT NULL,
	qA_1 INT NOT NULL DEFAULT 0,
	qA_2 INT NOT NULL DEFAULT 0,

	CONSTRAINT pk_qid PRIMARY KEY(qID)
);


INSERT INTO Questions(qC_1, qC_2) VALUES
('Eat bogger', 'Eat wax'),
('Player football in real life', 'Play football in a video game'),
('Cut off your right hand', 'Cut off your left hand'),
('Learn C#', 'Learn Java'),
('Watch anime', 'Read manga'),
('Wear black clothes the rest of your life', 'Wear white clothes the rest of your life'),
('Own a Ferrari', 'Own a Lamborgini'),
('Watch “13 reasons why”', 'Watch “Game of thrones”'),
('Live without WIFI', 'live without a TV'),
('Drink a cup of saliva', 'Drink a cup of blood'),
('Work at Microsoft', 'Work at Apple'),
('Eat 100 muggets', 'Eat 5 Rats'),
('Study only maths', 'Study only physics'),
('Have a PC', 'Have a MAC'),
('Drink 5 litres hot water', 'Drink 1 litre of bleach'),
('Never watch your favorite movie again', 'Watch your favorite move every single day'),
('Have only a facebook account', 'Have accounts on all social medias but facebook'),
('Betray others', 'Be betrayed by others'),
('Be eaten by a shark', 'Be eaten by a lion'),
('Have a $1,000,000', 'Go in a free trip around the world'),
('Be humiliated infront of your friends', 'Be humiliated infront of your family'),
('Be rich but never be able to experience work', 'Work very hard but get paid less'),
('Live in the victorian age', 'Live in the 15th century'),
('Live in a medieval era', 'Live on a futuristic era'),
('Live in a mansion alone', 'Live in a sheperd hut with your family'),
('Live in one house for the rest of your life', 'Move out every month to a house of your choice'),
('Starve', 'Dehydrate'),
('Be a nice person addicted to drugs', 'Be a murderer'),
('Know the truth of the universe', 'Have a $10,000,000'),
('Be rich but not famous', 'Be famous but not that rich'),
('Starve', 'Dehydrate'),
('Be extremely smart but have no friends', 'Have a below average IQ but have a lot of friends'),
('Wear wet socks for the rest of your life', 'Have a mosquito buzzing on your ear the rest of your life'),
('Live in france', 'Live in germany');

SELECT * FROM Questions;