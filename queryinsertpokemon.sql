use Pokemondb
insert into Pokemons (pName, type1, type2, abilities)
values ('Bulbasaur', 'Grass', 'Poison', 'Overgrow'),
('Ivysaur', 'Grass','Poison',  'Overgrow'),
('Venusaur', 'Grass', 'Poison', 'Overgrow'),
('Charmander', 'Fire', '', 'Blaze'),
('Charmeleon', 'Fire', '', 'Blaze'),
('Charizard', 'Fire', 'Flying', 'Blaze'),
('Squirtle', 'Water', '', 'Torrent'),
('Wartortle', 'Water', '', 'Torrent'),
('Blastoise', 'Water', '', 'Torrent');

insert into PokemonTrainers (Tname)
values ('Josefine');

create table Pokemons (pId int identity primary key, pName nvarchar(100), type1 nvarchar(50) not null, type2 nvarchar(50), abilities nvarchar(100), PokemontrainerTid int foreign key references PokemonTrainers(Tid));
select * from PokemonTrainers
select * from Pokemons