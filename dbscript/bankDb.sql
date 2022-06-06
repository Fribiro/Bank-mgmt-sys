create table ClientAccount (
	ClientAccountId INTEGER,
	ClientAccountType VARCHAR(15) NOT NULL,
	ClientAccountBalance VARCHAR(10),
	
	PRIMARY KEY(ClientAccountId,ClientAccountBalance)
);

create table ClientDeposits (
	DepositId INTEGER,
	DepositType VARCHAR(15),
	DepositAmount VARCHAR(10),
	DepositDate TIMESTAMP,
	DepositLocation VARCHAR(15),
	
	PRIMARY KEY(DepositId,DepositAmount,DepositDate)
);

create table ClientWithdrawals (
	WithdrawalId INTEGER,
	WithdrawalType VARCHAR(15),
	WithdrawalAmount VARCHAR(10),
	WithdrawalDate TIMESTAMP,
	WithdrawalLocation VARCHAR(15),
	
	PRIMARY KEY(WithdrawalId,WithdrawalAmount,WithdrawalDate)
);

create table BankClients (
	ClientId INTEGER NOT NULL,
	ClientFirstName VARCHAR(15) NOT NULL,
	ClientLastName VARCHAR(15) NOT NULL NOT NULL,
	ClientJoinDate TIMESTAMP NOT NULL,
	ClientPassword VARCHAR(256) NOT NULL,
	ClientEmail VARCHAR(100) NOT NULL,
	ClientPhone VARCHAR(12) NOT NULL,
	ClientStreet VARCHAR(30) NOT NULL,
	ClientZipCode VARCHAR(10) NOT NULL,
	ClientCity VARCHAR(15) NOT NULL,
	ClientAccountId INTEGER,
	ClientAccountBalance VARCHAR(10),
	DepositId INTEGER,
	DepositAmount VARCHAR(10),
	DepositDate TIMESTAMP,
	WithdrawalId INTEGER,
	WithdrawalAmount VARCHAR(10),
	WithdrawalDate TIMESTAMP,
	
	
	PRIMARY KEY(ClientId),
	CONSTRAINT FkClientAccount FOREIGN KEY(ClientAccountId,ClientAccountBalance) REFERENCES ClientAccount(ClientAccountId,ClientAccountBalance) ON DELETE CASCADE,
	CONSTRAINT FkClientDeposits FOREIGN KEY(DepositId,DepositAmount,DepositDate) REFERENCES ClientDeposits(DepositId,DepositAmount,DepositDate) ON DELETE CASCADE,
	CONSTRAINT FkClientWithdrawals FOREIGN KEY(WithdrawalId,WithdrawalAmount,WithdrawalDate) REFERENCES ClientWithdrawals(WithdrawalId,WithdrawalAmount,WithdrawalDate) ON DELETE CASCADE
);