create table MovieGenres(
 MovieGenreId int identity primary key,
 MovieId int ,
 GenreId int 
constraint fk_register_quiz foreign key (MovieId) references Movies (MovieId) on update cascade,
constraint fk_register_user foreign key (GenreId) references Genres (GenreId)on update cascade,
)