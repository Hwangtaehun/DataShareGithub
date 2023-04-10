<?php
try{
  $pdo = new PDO('mysql:host=192.168.1.30;dbname=test;charset=utf8','sj002','sj4321');
  $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
  $sql = 'CREATE TABLE `student` (
          `stu_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
          `stu_no` CHAR(4) NOT NULL,
          `stu_name` CHAR(10),
          `stu_address` TEXT,
          `stu_birthday` DATE
          ) DEFAULT CHARACTER SET utf8 ENGINE=InnoDB';
  $pdo->exec($sql);
  $strMsg = '학생 테이블 생성.';
  
  $sql = 'CREATE TABLE `score` (
          `sc_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
          `sc_no` CHAR(4) NOT NULL,
          `sc_cpp` INT,
          `sc_java` INT,
          `sc_av` FLOAT,
          `sc_grade` CHAR(1)
          ) DEFAULT CHARACTER SET utf8 ENGINE=InnoDB';
  $pdo->exec($sql);
  $strMsg .= '성적 테이블 생성.';
}
catch(PDOException $e){
  $strMsg = 'DB 오류: '.$e->getMessage().
  '<br>오류 발생 파일 : '.$e->getFile().
  '<br>오류 발생 행 : '.$e->getLine();
}
include __DIR__.'/../templates/msgOutput.html.php';
