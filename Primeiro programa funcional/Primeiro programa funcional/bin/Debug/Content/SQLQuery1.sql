Create TABLE tb_usuarios(
	login varchar(10) Not null,
	senha varchar(10) Not null
);

select * FROM tb_usuarios;

insert into tb_usuarios(login,senha) VALUES ('admin','admin123')