<?php

include_once __DIR__.'/../includes/Dbconnect.php';
include_once __DIR__.'/../includes/UserFunctions.php';

try{
    // $pdo = new PDO('mysql:host=192.168.1.30;dbname=test;charset=utf8','sj002','sj4321');
    // $pdo = new PDO('mysql:host=localhost;dbname=test;charset=utf8','mysejong','sj4321');
    // $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    if(isset($_POST['sc_no'])){
        // $sql = 'UPDATE `score` SET `sc_no` = :sc_no, `sc_cpp` = :sc_cpp, `sc_java` = :sc_java WHERE `sc_id` = :id';
        // $stmt = $pdo->prepare($sql);
        // $stmt->bindValue(':sc_no', $_POST['sc_no']);
        // $stmt->bindValue(':sc_cpp', $_POST['sc_cpp']);
        // $stmt->bindValue(':sc_java', $_POST['sc_java']);
        // $stmt->bindValue(':id', $_POST['sc_id']);
        // $stmt->execute();
        // updateScore($pdo, ['sc_no'=>$_POST['sc_no'], 'sc_cpp'=>$_POST['sc_cpp'], 'sc_java'=>$_POST['sc_java'], 'sc_id'=>$_POST['sc_id']]);
        updateData($pdo, 'score', 'sc_id', $_POST);
        header('location: sj6scoreList.php');
    }
    else {
        // $sql = 'SELECT * FROM `score` where `sc_id`='.$_GET['id'];
        // $result = $pdo->query($sql);
        // $row = $result->fetch();

        $row = selectScore($pdo, $_GET['id']);

        $title = '점수 수정';
        ob_start();
        include __DIR__.'/../templates/sj6scoreForm2.html.php';
        $outString = ob_get_clean();
    }
}
catch (PDOException $e){
    $outString = '<p>오류발생: '.$e->getMessage().$e->getFile().'행 : '.$e->getLine().'</p>';
}
include __DIR__.'/../templates/sj6layout.html.php';