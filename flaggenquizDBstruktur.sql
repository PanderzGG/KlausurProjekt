drop database if exists flaggenquiz;

create database flaggenquiz;

use flaggenquiz;

-- Tabelle "kontinente"
CREATE TABLE kontinente (
    kontinentID INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) UNIQUE NOT NULL
);

-- Tabelle "spieler"
CREATE TABLE spieler (
    spielerID INT PRIMARY KEY AUTO_INCREMENT,
    benutzername VARCHAR(50) UNIQUE NOT NULL
);

-- Tabelle "laender" (abhängig von "kontinente")
CREATE TABLE laender (
    landID INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(100) UNIQUE NOT NULL,
    hauptstadt VARCHAR(100) NOT NULL,
    flaggenpfad VARCHAR(255) NOT NULL,
    kontinentID INT NOT NULL,
    FOREIGN KEY (kontinentID) REFERENCES kontinente(kontinentID)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

-- Tabelle "scores" (abhängig von "spieler" und "quiztyp")
CREATE TABLE scores (
    scoreID INT PRIMARY KEY AUTO_INCREMENT,
    spielerID INT NOT NULL,
    punkte INT NOT NULL,
    datum DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (spielerID) REFERENCES spieler(spielerID)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

use flaggenquiz;

-- Kontinente einfügen
INSERT INTO kontinente (name) VALUES
('Afrika'),
('Asien'),
('Europa'),
('Nordamerika'),
('Südamerika'),
('Australien/Ozeanien'),
('Antarktika');

-- Länder einfügen
INSERT INTO laender (name, hauptstadt, flaggenpfad, kontinentID) VALUES
-- Afrika (kontinentID 1)
('Nigeria', 'Abuja', 'nigeria.png', 1),
('Ägypten', 'Kairo', 'aegypten.png', 1),
('Südafrika', 'Pretoria', 'suedafrika.png', 1),
('Kenia', 'Nairobi', 'kenia.png', 1),
('Marokko', 'Rabat', 'marokko.png', 1),
('Algerien', 'Algier', 'algerien.png', 1),
('Ghana', 'Accra', 'ghana.png', 1),
('Elfenbeinküste', 'Yamoussoukro', 'elfenbeinkueste.png', 1),
('Senegal', 'Dakar', 'senegal.png', 1),
('Kamerun', 'Yaoundé', 'kamerun.png', 1),
('Tansania', 'Dodoma', 'tansania.png', 1),
('Uganda', 'Kampala', 'uganda.png', 1),
('Angola', 'Luanda', 'angola.png', 1),
('Mosambik', 'Maputo', 'mosambik.png', 1),
('Madagaskar', 'Antananarivo', 'madagaskar.png', 1),

-- Asien (kontinentID 2)
('China', 'Peking', 'china.png', 2),
('Indien', 'Neu-Delhi', 'indien.png', 2),
('Japan', 'Tokio', 'japan.png', 2),
('Südkorea', 'Seoul', 'suedkorea.png', 2),
('Indonesien', 'Jakarta', 'indonesien.png', 2),
('Türkei', 'Ankara', 'tuerkei.png', 2),
('Saudi-Arabien', 'Riad', 'saudi_arabien.png', 2),
('Thailand', 'Bangkok', 'thailand.png', 2),
('Vietnam', 'Hanoi', 'vietnam.png', 2),
('Malaysia', 'Kuala Lumpur', 'malaysia.png', 2),
('Philippinen', 'Manila', 'philippinen.png', 2),
('Iran', 'Teheran', 'iran.png', 2),
('Irak', 'Bagdad', 'irak.png', 2),
('Pakistan', 'Islamabad', 'pakistan.png', 2),
('Bangladesch', 'Dhaka', 'bangladesch.png', 2),

-- Europa (kontinentID 3)
('Deutschland', 'Berlin', 'deutschland.png', 3),
('Frankreich', 'Paris', 'frankreich.png', 3),
('Italien', 'Rom', 'italien.png', 3),
('Spanien', 'Madrid', 'spanien.png', 3),
('Vereinigtes Königreich', 'London', 'vereinigtes_koenigreich.png', 3),
('Polen', 'Warschau', 'polen.png', 3),
('Schweden', 'Stockholm', 'schweden.png', 3),
('Norwegen', 'Oslo', 'norwegen.png', 3),
('Niederlande', 'Amsterdam', 'niederlande.png', 3),
('Belgien', 'Brüssel', 'belgien.png', 3),
('Österreich', 'Wien', 'oesterreich.png', 3),
('Schweiz', 'Bern', 'schweiz.png', 3),
('Griechenland', 'Athen', 'griechenland.png', 3),
('Portugal', 'Lissabon', 'portugal.png', 3),
('Dänemark', 'Kopenhagen', 'daenemark.png', 3),

-- Nordamerika (kontinentID 4)
('USA', 'Washington, D.C.', 'usa.png', 4),
('Kanada', 'Ottawa', 'kanada.png', 4),
('Mexiko', 'Mexiko-Stadt', 'mexiko.png', 4),
('Costa Rica', 'San José', 'costa_rica.png', 4),
('Kuba', 'Havanna', 'kuba.png', 4),
('Jamaika', 'Kingston', 'jamaika.png', 4),
('Guatemala', 'Guatemala-Stadt', 'guatemala.png', 4),
('Panama', 'Panama-Stadt', 'panama.png', 4),
('Haiti', 'Port-au-Prince', 'haiti.png', 4),
('Dominikanische Republik', 'Santo Domingo', 'dominikanische_republik.png', 4),

-- Südamerika (kontinentID 5)
('Brasilien', 'Brasília', 'brasilien.png', 5),
('Argentinien', 'Buenos Aires', 'argentinien.png', 5),
('Kolumbien', 'Bogotá', 'kolumbien.png', 5),
('Peru', 'Lima', 'peru.png', 5),
('Chile', 'Santiago', 'chile.png', 5),
('Venezuela', 'Caracas', 'venezuela.png', 5),
('Ecuador', 'Quito', 'ecuador.png', 5),
('Bolivien', 'Sucre', 'bolivien.png', 5),
('Paraguay', 'Asunción', 'paraguay.png', 5),
('Uruguay', 'Montevideo', 'uruguay.png', 5),

-- Australien/Ozeanien (kontinentID 6)
('Australien', 'Canberra', 'australien.png', 6),
('Neuseeland', 'Wellington', 'neuseeland.png', 6),
('Fidschi', 'Suva', 'fidschi.png', 6),
('Papua-Neuguinea', 'Port Moresby', 'papua_neuguinea.png', 6),
('Samoa', 'Apia', 'samoa.png', 6);