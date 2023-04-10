<?php
try{
  $pdo = new PDO('mysql:host=192.168.1.30; dbname = test; charset=utf8', 'sj002', 'sj4321');
  $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
  $strMsg = 'DB 접속 성공 3';
}
catch(PDOException $e){
  $strMsg = 'DB 접속 오류: '.$e->getMessage().
            '<br>오류 발생 파일 :'.$e->getFile().
            '<br>오류 발생 행 :'.$e->getLine();
}
include __DIR__.'/../templates/msgOutput.html.php';
