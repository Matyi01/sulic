CREATE TABLE `kuldetes` (
  `id` int(11) NOT NULL,
  `megnevezes` varchar(100) ,
  `kezdet` date NOT NULL,
  `veg` date NOT NULL
) ;


CREATE TABLE `repules` (
  `urhajosid` int(11) NOT NULL,
  `kuldetesid` int(11) NOT NULL
) ;


CREATE TABLE `urhajos` (
  `id` int(11) NOT NULL,
  `nev` varchar(100) ,
  `orszag` varchar(100) ,
  `nem` varchar(100) ,
  `szulev` int(11) NOT NULL,
  `urido` varchar(100) 
) ;


ALTER TABLE `repules`
  ADD PRIMARY KEY (`urhajosid`,`kuldetesid`);


ALTER TABLE `urhajos`
  ADD PRIMARY KEY (`id`);
COMMIT;