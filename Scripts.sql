CREATE TABLE Clientes(
    CodCliente integer identity(1, 1) not null,
    Nome varchar(80) not null,
    Telefone varchar(11) not null,
    CPF varchar(11) UNIQUE not null,
    Endereco varchar(100) not null,
    CONSTRAINT PK_CodCliente PRIMARY KEY (CodCliente)
);

INSERT INTO
    Clientes (Nome, Telefone, CPF, Endereco)
VALUES
    (
        'Gustavo',
        '54999541758',
        '03599626022',
        'Selbach'
    );

INSERT INTO
    Clientes (Nome, Telefone, CPF, Endereco)
VALUES
    (
        'Ewerton',
        '54999656736',
        '04758484755',
        'Selbach'
    );

INSERT INTO
    Clientes (Nome, Telefone, CPF, Endereco)
VALUES
    ('Iago', '54999955566', '01255484635', 'Ibirubá');

CREATE TABLE Produtos (
    CodProduto integer identity(1, 1) not null,
    Nome varchar(80) not null,
    ValorUnitario decimal(8, 2) not null,
    Tamanho char(3) not null,
    CONSTRAINT PK_CodProduto PRIMARY KEY (CodProduto)
);

INSERT INTO
    Produtos (Nome, ValorUnitario, Tamanho)
VALUES
    ('Camiseta DiCorpo', 199.99, 'M');

INSERT INTO
    Produtos (Nome, ValorUnitario, Tamanho)
VALUES
    ('Calça DiCorpo', 599.99, 'PP');

CREATE TABLE PedidoFornecedores (
    CodPedidoF integer identity(1, 1) not null,
    ValorTotal decimal(8, 2) not null,
    TotalParcelas integer not null,
    Status char(1) not null,
    Data date not null,
    CONSTRAINT PK_CodPedido PRIMARY KEY (CodPedidoF)
);

INSERT INTO
    PedidoFornecedores (ValorTotal, TotalParcelas, Status, Data)
VALUES
    (100.99, 0, 'P', '2023-01-05');

INSERT INTO
    PedidoFornecedores (ValorTotal, TotalParcelas, Status, Data)
VALUES
    (99, 1, 'P', '2023-01-05');

CREATE TABLE PedidoClientes (
    CodPedidoC integer identity(1, 1) not null,
    CodCliente integer not null,
    ValorTotal decimal(8, 2) not null,
    TotalParcelas integer not null,
    Status char(1) not null,
    Data date not null,
    CONSTRAINT PK_CodPedidoC PRIMARY KEY (CodPedidoC),
    CONSTRAINT FK_Clientes_PedidoClientes FOREIGN KEY (CodCliente) REFERENCES Clientes (CodCliente),
);

INSERT INTO
    PedidoClientes (
        CodCliente,
        ValorTotal,
        TotalParcelas,
        Status,
        Data
    )
VALUES
    (1, 199.99, 0, 'P', '2023-01-05');

CREATE TABLE Parcelas (
    CodParcela integer identity(1, 1) not null,
    Valor decimal(8, 2) not null,
    DtPagamento date not null,
    CodPedidoForncedor integer,
    CodPedidoCliente integer,
    Status char(1) not null,
    CONSTRAINT PK_CodParcela PRIMARY KEY (CodParcela),
    CONSTRAINT FK_PedidoForncedores_Parcelas FOREIGN KEY (CodPedidoForncedor) REFERENCES PedidoFornecedores (CodPedidoF),
    CONSTRAINT FK_PedidoClientes_Parcelas FOREIGN KEY (CodPedidoCliente) REFERENCES PedidoClientes (CodPedidoC)
);

CREATE TABLE ItemsPedidosClientes(
    CodItemPedido integer identity(1, 1) not null,
    Quantidade integer not null,
    CodProduto integer not null,
    CodPedidoCliente integer not null,
    CONSTRAINT PK_CodItemPedidosClientes PRIMARY KEY (CodItemPedido),
    CONSTRAINT FK_ItemsPedidosClientes_Produtos FOREIGN KEY (CodProduto) REFERENCES Produtos(CodProduto),
    CONSTRAINT FK_PedidoClientes_ItemsPedidosClientes FOREIGN KEY (CodPedidoCliente) REFERENCES PedidoClientes (CodPedidoC)
);

CREATE TABLE ItemsPedidosFornecedor(
    CodItemPedido integer identity(1, 1) not null,
    Quantidade integer not null,
    CodProduto integer not null,
    CodPedidoFornecedor integer not null,
    CONSTRAINT PK_CodItemPedidosFornecedor PRIMARY KEY (CodItemPedido),
    CONSTRAINT FK_ItemsPedidos_Produtos FOREIGN KEY (CodProduto) REFERENCES Produtos(CodProduto),
    CONSTRAINT FK_PedidoFornecedorFornecedor_ItemsPedidosFornecedor FOREIGN KEY (CodPedidoFornecedor) REFERENCES PedidoFornecedores (CodPedidoF)
);