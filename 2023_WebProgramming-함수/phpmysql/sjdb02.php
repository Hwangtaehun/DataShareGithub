<?php
try{
  $pdo = new PDO('mysql:host=192.168.1.30; dbname = test; charset=utf8', 'sj002', 'sj4321');
  $strMsg = 'MariaDB 접속 확인 2';
}
catch (PDOException $e){
  $strMsg = 'DB 접속 오류: '.$e;
}

include __DIR__.'/../templates/msgOutput.html.php';
