<?php
try {
    include_once __DIR__.'/../includes/Dbconnect.php';
    //include_once __DIR__.'/../includes/UserFunctions.php';
    include_once __DIR__.'/../class/TableManager.php';

    // $pdo = new PDO('mysql:host=192.168.1.30;dbname=test;charset=utf8','sj002','sj4321');
    // $pdo = new PDO('mysql:host=localhost;dbname=test;charset=utf8','mysejong','sj4321');
    // $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    // $sql = 'SELECT * FROM `score`';
    // $result = $pdo->query($sql);
    //$result = selectAllScore($pdo);
    //$result = selectAllData($pdo, 'score');
    
    $stuTable = new TableManager($pdo, 'student', 'stu_no');
    $scoreTable = new TableManager($pdo, 'score', 'sc_no');

    $scoreResult = $scoreTable->selectAll();

    $result=[];
    foreach ($scoreResult as $row) {
        //1.
        // $sql = 'SELECT * FROM `student` WHERE `stu_no` = '.$row['sc_no'];
        // $stuResult = $pdo->query($sql);
        // $stuRow = $stuResult->fetch();
        //2.
        //$stuRow = $stuTable->selectID($row['sc_no']);
        if(!($stuRow = $stuTable->selectID($row['sc_no'])))
            $stuRow['stu_name'] = '이름없다';
        $result[] = [
            'sc_id'=>$row['sc_id'],
            'sc_no'=>$row['sc_no'],
            'stu_name'=>$stuRow['stu_name'],
            'sc_cpp'=>$row['sc_cpp'],
            'sc_java'=>$row['sc_java'],
            'sc_av'=>$row['sc_av'],
            'sc_grade'=>$row['sc_grade']
        ];
    }

    $title = '수강생 점수 현황';
    ob_start();
    include __DIR__.'/../templates/sj6scoreList.html.php';
    $outString = ob_get_clean();
}
catch(PDOException $e){
    $outString = '<p>오류발생 : '.$e->getMessage().$e->getFile().' 행 : '.$e->getLine().'</p>';
}
include __DIR__.'/../templates/sj6layout.html.php';