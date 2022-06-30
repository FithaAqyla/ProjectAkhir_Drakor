	create database projectakhir

	drop database projectakhir

	use projectakhir
	go
	create table pelanggan(
	IdPelanggan char(3) primary key,
	NamaPelanggan varchar(50),
	Nohp varchar(13),)

	drop table transaksi

	create table transaksi(
	NoKwitansi char(8) primary key,
	TglKwitansi date,
	IdPelanggan char(3) foreign key references pelanggan(IdPelanggan),
	Nama_Pelanggan varchar(50),
	IDFilm char(10) foreign key references listdrakor(IDFilm),
	Judul varchar(50),
	Harga int,
	Jumlah int,
	TotalHarga int
	)

	drop table pelanggan

	create table listdrakor(
	IDFilm char(10) primary key,
	Judul varchar(50),
	Genre varchar(50),
	Harga int)
	ALTER TABLE listdrakor add foto Image


	create table AdminLog(
	username varchar(50),
	password varchar(50)
	)
	drop table AdminLog

	create proc SP_AdminLog
	@username varchar(50),
	@password varchar(50)
	as
	begin
	insert into AdminLog(username,password) values (@username,@password)
	end
	drop proc SP_AdminLog



	create table KasirLog(
	Idkasir int primary key,
	username varchar(50),
	password varchar(50)
	)
	create proc SP_KasirLog
	@IdKasir int,
	@username varchar(50),
	@password varchar(50)
	as
	begin
	insert into KasirLog(IdKasir,username,password)values(@IdKasir,@username,@password)
	end
	drop proc SP_AdminLog


	create proc SP_pelanggan_Insert
	@IdPelanggan char(3),
	@NamaPelanggan varchar(50),
	@Nohp varchar(13)
	as
	begin 
	insert into pelanggan(IdPelanggan, NamaPelanggan, Nohp) values (@IdPelanggan, @NamaPelanggan,@Nohp)
	end

	create proc SP_pelanggan_Update
	@IdPelanggan char(3),
	@NamaPelanggan varchar(50),
	@Nohp varchar(13)
	as
	begin 
	Update pelanggan set IdPelanggan=@IdPelanggan, NamaPelanggan=@NamaPelanggan, Nohp=@Nohp where IdPelanggan = @IdPelanggan
	end

	drop proc SP_pelanggan_Update


	create proc SP_pelanggan_Delete
	@IdPelanggan char(10)
	as
	begin 
	Delete pelanggan where IdPelanggan=@IdPelanggan 
	end

	drop proc SP_pelanggan_Update

	create proc SP_pelanggan_View
	as
	begin	
	select * from  pelanggan
	end

	create proc SP_listdrakor_Insert
	@IDFilm char(10),
	@Judul varchar(50),
	@Genre varchar(10),
	@Harga int
	as
	begin 
	insert into listdrakor(IDFilm, Judul, Genre,Harga) Values (@IDFilm,@Judul,@Genre,@Harga)
	end

	create proc SP_listdrakor_Update
	@IDFilm char(10),
	@Judul varchar(50),
	@Genre varchar(10),
	@Harga int
	as
	begin 
	Update listdrakor set IDFilm=@IDFilm, Judul=@Judul, Genre=@Genre, Harga = @Harga
	end


	create proc SP_listdrakor_Delete
	@IDFilm char(10)
	as
	begin 
	Delete listdrakor where IDFilm=@IDFilm 
	end

	create proc SP_listdrakor_View
	as
	begin 
	select * from  listdrakor
	end