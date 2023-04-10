<?php
try {
    // $pdo = new PDO('mysql:host=192.168.1.30;dbname=test;charset=utf8','sj002','sj4321');
    // $pdo = new PDO('mysql:host=localhost;dbname=test;charset=utf8','mysejong','sj4321');
    // $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    include_once __DIR__.'/../includes/Dbconnect.php';
    include_once __DIR__.'/../includes/UserFunctions.php';
    // $sql = 'SELECT * FROM `score`';
    // $result = $pdo->query($sql);

    //$result = selectAllScore($pdo);
    $result = selectAllData($pdo, 'score');

    $title = '수강생 점수 현황';
    ob_start();
    include __DIR__.'/../templates/sj6scoreList.html.php';
    $outString = ob_get_clean();
}
catch(PDOException $e){
    $outString = '<p>오류발생 : '.$e->getMessage().$e->getFile().' 행 : '.$e->getLine().'</p>';
}
include __DIR__.'/../templates/sj6layout.html.php';