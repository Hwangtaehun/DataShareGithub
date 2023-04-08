DROP DATABASE IF EXISTS  test;
DROP USER IF EXISTS  mysejong@localhost;
use mysql;
create user mysejong@localhost identified by 'sj4321';
create database test;
grant all privileges on test.* to mysejong@localhost with grant option;
commit;