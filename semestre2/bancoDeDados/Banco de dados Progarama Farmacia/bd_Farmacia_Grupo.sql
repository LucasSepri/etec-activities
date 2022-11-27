create database	banco;

CREATE TABLE `tb_dados_cadastrais` (
  `cd_Cpf_Cnpj` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `ds_Rg` VARCHAR(12) NOT NULL,
  `nm_Nome_Razao_Social` VARCHAR(100) NOT NULL,
  `ds_Pessoa_Fisica_Juridica` ENUM('Pessoa Física', 'Pessoa Jurídica') NOT NULL,
  `ds_Apelido` VARCHAR(30) NOT NULL,
  `ds_Data_Nascimento_Abertura` DATE NOT NULL,
  `ds_Naturalidade` VARCHAR(30) NOT NULL,
  `ds_Sexo` ENUM('Masculino', 'Feminino') NOT NULL,
  `ds_Endereco` VARCHAR(255) NOT NULL,
  `nu_Numero_Do_Endereco` INT NOT NULL,
  `ds_Complemento` VARCHAR(30) NOT NULL,
  `ds_Cep` VARCHAR(10) NOT NULL,
  `ds_Bairro` VARCHAR(30) NOT NULL,
  `ds_Estado` VARCHAR(25) NOT NULL,
  `ds_Municipio` VARCHAR(35) NOT NULL,
  `ds_Telefone_Fixo` VARCHAR(9) NOT NULL,
  `ds_Celular` VARCHAR(9) NOT NULL,
  `ds_Email` VARCHAR(50) NOT NULL,
  `ds_Site` VARCHAR(50) NOT NULL,
  `ds_Cartao_Fidelidade` VARCHAR(20) NOT NULL,
  `ds_Pontos` INT NOT NULL,
  PRIMARY KEY (`cd_Cpf_Cnpj`));

CREATE TABLE `tb_perfil_do_cliente` (
  `cd_Perfil_do_Cliente` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `ds_Estado_Civil` VARCHAR(15) NOT NULL,
  `ds_Nome_Conjugue` VARCHAR(100) NOT NULL,
  `ds_Filhos` VARCHAR(15) NOT NULL,
  `ds_Idade` INT NOT NULL,
  `ds_Profissao` VARCHAR(45) NOT NULL,
  `nm_Nome_da_Empresa` VARCHAR(50) NOT NULL,
  `ds_Aceita_Receber_Promocoes` VARCHAR(45) NOT NULL,
  `ds_Via` ENUM('SMS', 'E-MAIL') NOT NULL,
  `ds_Perfil_de_Consumo` VARCHAR(35) NOT NULL,
  `ds_Preferencia_Marca` VARCHAR(35) NOT NULL,
  `ds_Particularidades` VARCHAR(35) NOT NULL,
  `ds_Informacoes_Gerais` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`cd_Perfil_do_Cliente`));

CREATE TABLE `tb_condicoes_de_pagamento` (
  `cd_Pagamento` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `ds_Metodo_Pagamento` ENUM('Dinheiro', 'Cartão de Debito', 'Cartão de Credito') NOT NULL,
  `ds_Limite_Compra` INT NOT NULL,
  `ds_Descontos` DECIMAL(2,2) NOT NULL,
  `ds_Pbm` VARCHAR(12) NOT NULL,
  PRIMARY KEY (`cd_Pagamento`));


CREATE TABLE `tb_historico_do_cliente` (
  `cd_Numero_Cadastro` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `ds_Data_Do_Cadastro` DATE NOT NULL,
  `ds_Data_Ultima_Compra` DATE NOT NULL,
  `ds_Valor_Da_Compra` DECIMAL(3,2) NOT NULL,
  `ds_Prod_Frequencia_Compra` VARCHAR(45) NOT NULL,
  `ds_Serviços_Mais_Ultilizados` VARCHAR(45) NOT NULL,
  `ds_Reclamacoes` VARCHAR(255) NOT NULL,
  `tb_condicoes_de_pagamento_cd_Pagamento` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`cd_Numero_Cadastro`),
  CONSTRAINT `fk_tb_historico_do_cliente_tb_condicoes_de_pagamento1`
    FOREIGN KEY (`tb_condicoes_de_pagamento_cd_Pagamento`)
    REFERENCES `tb_condicoes_de_pagamento` (`cd_Pagamento`));


CREATE TABLE `tb_tipos_de_doencas` (
  `cd_tb_tipos_de_doencas` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `ds_doecas_cronicas` INT NOT NULL,
  `ds_Medicamentos_De_Alergia` INT NOT NULL,
  `ds_Medicamentos_De_Uso_Continuo` INT NOT NULL,
  `ds_Medicamento_De_Uso_Controlado` INT NOT NULL,
  PRIMARY KEY (`cd_tb_tipos_de_doencas`));


CREATE TABLE `tb_qual_o_tipo` (
  `cd_tb_qual_o_tipo` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `ds_Qual_A_Doenca_Cronica` VARCHAR(115) NOT NULL,
  `ds_Qual_O_Medicamento_Da_Alergia` VARCHAR(115) NOT NULL,
  `ds_Qual_O_Medicamento_De_Uso_Continuo` VARCHAR(115) NOT NULL,
  `ds_Qual_O_Medicamento_Controlado` VARCHAR(115) NOT NULL,
  PRIMARY KEY (`cd_tb_qual_o_tipo`));









CREATE TABLE `tb_dados_cadastrais_historico_do_cliente` (
  `cd_dados_cadastrais_historico_do_cliente` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `tb_dados_cadastrais_cd_Cpf_Cnpj` INT NOT NULL,
  `tb_historico_do_cliente_cd_Numero_Cadastro` INT NOT NULL,
  PRIMARY KEY (`cd_dados_cadastrais_historico_do_cliente`),
  CONSTRAINT `fk_tb_dados_cadastrais_has_tb_historico_do_cliente_tb_dados_c`
    FOREIGN KEY (`tb_dados_cadastrais_cd_Cpf_Cnpj`)
    REFERENCES `tb_dados_cadastrais` (`cd_Cpf_Cnpj`),
  CONSTRAINT `fk_tb_dados_cadastrais_has_tb_historico_do_cliente_tb_histori1`
    FOREIGN KEY (`tb_historico_do_cliente_cd_Numero_Cadastro`)
    REFERENCES `tb_historico_do_cliente` (`cd_Numero_Cadastro`));


CREATE TABLE `tb_historico_do_cliente_perfil_do_cliente` (
  `cd_historico_do_cliente_perfil_do_cliente` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `tb_historico_do_cliente_cd_Numero_Cadastro` INT NOT NULL,
  `tb_perfil_do_cliente_cd_Perfil_do_Cliente` INT NOT NULL,
  PRIMARY KEY (`cd_historico_do_cliente_perfil_do_cliente`),
  CONSTRAINT `fk_tb_historico_do_cliente_has_tb_perfil_do_cliente_tb_histor1`
    FOREIGN KEY (`tb_historico_do_cliente_cd_Numero_Cadastro`)
    REFERENCES `mydb`.`tb_historico_do_cliente` (`cd_Numero_Cadastro`),
  CONSTRAINT `fk_tb_historico_do_cliente_has_tb_perfil_do_cliente_tb_perfil1`
    FOREIGN KEY (`tb_perfil_do_cliente_cd_Perfil_do_Cliente`)
    REFERENCES `mydb`.`tb_perfil_do_cliente` (`cd_Perfil_do_Cliente`));


CREATE TABLE `tb_tipos_de_doencas_qual_o_tipo` (
  `cd_tipos_de_doencas_qual_o_tipo` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `tb_tipos_de_doencas_cd_tb_tipos_de_doencas` INT NOT NULL,
  `tb_qual_o_tipo_cd_tb_qual_o_tipo` INT NOT NULL,
  `tb_historico_do_cliente_cd_Numero_Cadastro` INT NOT NULL,
  PRIMARY KEY (`cd_tipos_de_doencas_qual_o_tipo`),
  CONSTRAINT `fk_tb_tipos_de_doencas_has_tb_qual_o_tipo_tb_tipos_de_doencas1`
    FOREIGN KEY (`tb_tipos_de_doencas_cd_tb_tipos_de_doencas`)
    REFERENCES `tb_tipos_de_doencas` (`cd_tb_tipos_de_doencas`),
  CONSTRAINT `fk_tb_tipos_de_doencas_has_tb_qual_o_tipo_tb_qual_o_tipo1`
    FOREIGN KEY (`tb_qual_o_tipo_cd_tb_qual_o_tipo`)
    REFERENCES `tb_qual_o_tipo` (`cd_tb_qual_o_tipo`),
  CONSTRAINT `fk_tb_tipos_de_doencas_qual_o_tipo_tb_historico_do_cliente1`
    FOREIGN KEY (`tb_historico_do_cliente_cd_Numero_Cadastro`)
    REFERENCES `tb_historico_do_cliente` (`cd_Numero_Cadastro`));
    
    

