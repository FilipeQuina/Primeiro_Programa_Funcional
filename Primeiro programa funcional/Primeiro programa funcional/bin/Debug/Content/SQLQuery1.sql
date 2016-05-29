Create TABLE tb_usuarios(
	login varchar(10) Not null,
	senha varchar(10) Not null
);

select * FROM tb_usuarios;

select * FROM ordemServico;

insert into tb_usuarios(login,senha) VALUES ('admin','admin123')

create table ordemServico (
	id int not null,
	codOs Varchar (20) not null,
	dataAbertura date default CURRENT_TIMESTAMP,
	datafechamento date,
	descricao varChar (50) not null,
	prioridade varchar(20) CHECK (prioridade IN('1-Normal','2-Urgente','3-Muito Urgente')),
	manutentor varchar(20) not null
);
exec sp_rename 'ordemServico.[datafechamento]', 'dataFechamento', 'column'

SELECT codOs, prioridade, dataAbertura, descricao, manutentor FROM ordemServico WHERE dataFechamento IS NULL