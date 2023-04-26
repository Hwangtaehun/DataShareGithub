<?php
try{
    $pdo = new PDO('mysql:host=localhost;dbname=test;charset=utf8', 'mysejong', 'sj4321');
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION)

    $sql = 'CREATE TABLE `author` (
           `id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
           `userid` CHAR(10) NOT NULL,
           `name` CHAR(10),
           `password` CHAR(10),
           `email` CHAR(10)) DEFAULT CHARCTER SET utf8 ENGINE=InnoDB';
}
catch(PDOException $e){
    $strMsg = 'DB 오류: '.$e->getMessage().
              '<br>오류 발생 파일 : '.$e->getFile().
              '<br>오류 발생 행 : '.$e->getLine();
}
include __DIR__'/../templates/msgOutput.html.php';