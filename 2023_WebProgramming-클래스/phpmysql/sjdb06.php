<?php
try{
  $pdo = new PDO('mysql:host=192.168.1.30;dbname=test;charset=utf8','sj002','sj4321');
  $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
  $pdo->exec('INSERT INTO `student` (`stu_no`, `stu_name`, `stu_address`, `stu_birthday`)'
            .'VALUES(\'1001\', \'홍길동\', \'사창동\', \'2000-1-1\')');
  $pdo->exec('INSERT INTO `student` (`stu_no`, `stu_name`, `stu_address`, `stu_birthday`)'
            .'VALUES("1002", "김유신", "분평동", "2001-2-2")');
  $pdo->exec('INSERT INTO `student` (`stu_no`, `stu_name`, `stu_address`, `stu_birthday`)'
            .'VALUES(\'1003\', \'강감찬\', \'사직동\', \'2002-3-3\')');
  $pdo->exec('INSERT INTO `student` (`stu_no`, `stu_name`, `stu_address`, `stu_birthday`)'
            .'VALUES(\'1004\', \'장보고\', \'용암동\', \'2000-4-4\')');
  $pdo->exec('INSERT INTO `student` (`stu_no`, `stu_name`, `stu_address`, `stu_birthday`)'
            .'VALUES(\'1005\', \'김길동\', \'개신동\', \'2000-5-5\')');
            
  $pdo->exec('INSERT INTO `score` (`sc_no`, `sc_cpp`, `sc_java`) VALUES ("1001", 99, 99)');
  $pdo->exec('INSERT INTO `score` (`sc_no`, `sc_cpp`, `sc_java`) VALUES ("1002", 88, 78)');
  $pdo->exec('INSERT INTO `score` (`sc_no`, `sc_cpp`, `sc_java`) VALUES ("1003", 99, 45)');
  $pdo->exec('INSERT INTO `score` (`sc_no`, `sc_cpp`, `sc_java`) VALUES ("1004", 88, 100)');
  $pdo->exec('INSERT INTO `score` (`sc_no`, `sc_cpp`, `sc_java`) VALUES ("1005", 100, 100)');
  
  $strMsg = '자료 추가 성공.';
}
catch (PDOException $e){
  $strMsg = 'DB 오류: '.$e->getMessage().'<br>오류 발생 파일 : '.$e->getFile().
            '<br>오류 발생 행 : '.$e->getLine();
}
include __DIR__.'/../templates/msgOutput.html.php';
