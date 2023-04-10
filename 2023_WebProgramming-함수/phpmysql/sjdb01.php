<?php

try{
  //$pdo = new PDO('mysql:host=192.168.1.30; dbname = test; charset=utf8', 'sj002', 'sj4321');
  $pdo = new PDO('mysql:host=localhost; dbname = test; charset=utf8', 'mysejong', 'sj4321');
  echo 'MariaDB접속 성공 1';
}
catch(PDOException $e){
  echo 'DB 접속 오류 : '.$e;
}
