<?php
try{
  $pdo = new PDO('mysql:host=192.168.1.30;dbname=test;charset=utf8','sj002','sj4321');
  $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
  
  $sql = <<<AAA
         INSERT INTO `student` (`stu_no`, `stu_name`, `stu_address`, `stu_birthday`)
         VALUES('1001', '홍길동', '사창동', '2000-1-1')
  AAA;
  
  $pdo->exec($sql);
  $strMsg = '자료 추가 성공.';
}
catch(PDOException $e){
  $strMsg = 'DB 오류: '.$e->getMessage().'<br>오류 발생 파일 : '.$e->getFile().
            '<br>오류 발생 행 : '.$e->getLine();
}
include __DIR__.'/../templates/msgOutput.html.php';
