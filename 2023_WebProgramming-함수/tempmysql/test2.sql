use madang

-- Select Banks.id, Banks.price, Manager.title, Banks.date, Connection.title, Banks.inform, Banks.balance 
-- From Banks left join Manager on Banks.manid = Manager.manid left join Connection on Banks.conid = Connection.conid;

-- Select manid From Manager Where manid like '1__00';
-- Select manid From Manager Where manid like '2__00';
-- Select conid From Connection Where conid like '%0000';
-- Select title From Manager Where manid like '%0000';
-- Select title From Connection Where conid like '%0000';
-- Select conid From Connection Where conid like '1__00';
-- Select manid FROM Manager order by manid;
-- Select manid FROM Manager WHERE manid like '1__00';
-- Select manid FROM Manager WHERE manid like '1%00';
-- Select manid From Manager Where manid like '_0000';
-- Select conid From Connection Where conid like '_0000';
-- Select manid From Manager Where manid like '101__';
-- Select manid From Manager Where manid like '101%';
-- Select conid From Connection Where conid like '1%';
-- Select manid From Manager Where manid like '1%';

-- Select Banks.bankid, Incomes.deposit, Expenses.spend, Banks.bankdate, Incomes.in_inform, Expenses.ex_inform, Banks.balance
-- From Banks left join Expenses on Banks.expenseid = Expenses.expenseid left join Incomes on Banks.incomeid = Incomes.incomeid;

-- Select SUM(deposit) as 수입 From Incomes;
-- Select SUM(spend) as 지출 From Expenses;
-- Select SUM(deposit) + SUM(spend) as 남은돈 From Banks left join Expenses on Banks.expenseid = Expenses.expenseid left join Incomes on Banks.incomeid = Incomes.incomeid;

-- Update Banks set bankid = 2 Where bankid = 3;

-- Select Banks.bankid, Incomes.deposit, Expenses.spend, Incomes.incomedate, Expenses.expensedate, Incomes.in_inform, Expenses.ex_inform, Banks.balance
-- From Banks left join Expenses on Banks.expenseid = Expenses.expenseid left join Incomes on Banks.incomeid = Incomes.incomeid;

-- Select * FROM Banks WHERE bankid = 3

-- INSERT INTO Banks VALUES(5, 10901, 1000, STR_TO_DATE('2023-01-01','%Y-%m-%d'), 10400, 'test1', null);
-- INSERT INTO Banks VALUES(6, 10901, 500, STR_TO_DATE('2023-01-01','%Y-%m-%d'), 10400, 'test2', null);
-- Select Banks.id, Banks.price, Manager.title, Banks.date, Connection.title, Banks.inform, Banks.balance
-- From Banks left join Manager on Banks.manid = Manager.manid left join Connection on Banks.conid = Connection.conid;
-- UPDATE Banks SET manid = 999999 WHERE manid = 10901;
-- UPDATE Banks SET conid = 999999 WHERE conid = 10400;
-- Select Banks.id, Banks.price, Manager.title, Banks.date, Connection.title, Banks.inform, Banks.balance
-- From Banks left join Manager on Banks.manid = Manager.manid left join Connection on Banks.conid = Connection.conid;

-- Select Banks.id, Banks.price, Manager.title, Banks.date, Connection.title, Banks.inform, Banks.balance 
-- From Banks left join Manager on Banks.manid = Manager.manid left join Connection on Banks.conid = Connection.conid
-- Where Banks.date = STR_TO_DATE('2023-01-01', '%Y-%m-%d');

Select Banks.id, Banks.price, Manager.title, Banks.date, Connection.title, Banks.inform, Banks.balance 
From Banks left join Manager on Banks.manid = Manager.manid left join Connection on Banks.conid = Connection.conid
Where Banks.date BETWEEN '2023-01-01' AND '2023-12-31';