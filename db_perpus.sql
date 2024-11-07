create database db_perpus_fix

ON PRIMARY(
	name = db_perpus_fix,
	filename = 'D:\Hanip\Materi\Pemrograman Lanjut\Final Project\Database\db_perpus_fix.mdf',
	size = 10,
	maxsize = 50,
	filegrowth = 2)
LOG ON (
	name = db_perpus_fix_log,
	filename = 'D:\Hanip\Materi\Pemrograman Lanjut\Final Project\Database\db_perpus_fix_log.ldf',
	size = 3,
	maxsize = 20,
	filegrowth = 1);

use db_perpus_fix;

create table pendaftaran (
	kd_daftar char(5) not null primary key,
	tanggal_daftar datetime not null,
	bayar_daftar numeric not null,
	nama_anggota varchar(20) not null,
	alamat_anggota varchar(50) not null,
	tempat_lahir_anggota char(10) not null,
	tanggal_lahir_anggota datetime not null,
	jenis_kel_anggota char(1) not null,
	jenis_anggota char(10) not null );

create table anggota (
	id_anggota char(5) not null primary key,
	nama_anggota varchar(20) not null,
	telepon_anggota varchar(15) null,
	alamat_anggota varchar(50) not null,
	jenis_kel_anggota char(1) not null,
	tempat_lahir_anggota char(10) not null,
	tanggal_lahir_anggota datetime not null,
	tanggal_daftar datetime not null,
	bayar_daftar numeric not null );

create table denda (
	kd_denda char(8) not null primary key,
	keterangan varchar(50) null,
	kd_pinjam char(5) foreign key references peminjaman(kd_pinjam),
	id_petugas char(5) foreign key references petugas(id_petugas),
	tanggal_denda datetime not null,
	bayar_denda numeric not null );

create table buku (
	kd_buku char(5) not null primary key,
	nama_buku varchar(20) not null,
	tahun_buku datetime null,
	bahasa_buku char(10) null,
	pengarang_buku varchar(20) not null,
	penerbit_buku varchar(20) null,
	jumlah_buku numeric null,
	harga_buku numeric null );

create table petugas (
	id_petugas char(5) not null primary key,
	nama_petugas varchar(20) not null,
	telepon_petugas varchar(15) null,
	password varchar(10) not null);

create table peminjaman (
	kd_pinjam char(5) not null primary key,
	tanggal_pinjam datetime not null,
	tanggal_kembali datetime not null,
	jumlah_buku numeric not null,
	id_anggota char(5) foreign key references anggota(id_anggota),
	kd_buku char(5) foreign key references buku(kd_buku));

insert into petugas values ('23469','Hanip','085643228216','hanip123');