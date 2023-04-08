<?php

include_once __DIR__.'/../includes/Dbconnect.php';
include_once __DIR__.'/../includes/UserFunctions.php';

try{
    // $pdo = new PDO('mysql:host=192.168.1.30;dbname=test;charset=utf8','sj002','sj4321');
    // $pdo = new PDO('mysql:host=localhost;dbname=test;charset=utf8','mysejong','sj4321');
    // $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    if(isset($_POST['stu_no'])){
        //$sql = 'UPDATE `student` SET `stu_no` = :stu_no, `stu_name` = :stu_name, `stu_address` = :stu_address, `stu_birthday` = :stu_birthday WHERE `stu_id` = :id';
        //$stmt = $pdo->prepare($sql);
        //$stmt->bindValue(':stu_no', $_POST['stu_no']);
        //$stmt->bindValue(':stu_name', $_POST['stu_name']);
        //$stmt->bindValue(':stu_addr', $_POST['stu_addr']);
        //$stmt->bindValue(':stu_bday', $_POST['stu_bday']);
        //$stmt->bindValue(':stu_address', $_POST['stu_address']);
        //$stmt->bindValue(':stu_birthday', $_POST['stu_birthday']);
        //$stmt->bindValue(':id', $_POST['stu_id']);
        //$stmt->execute();
        updateData($pdo, 'student', 'stu_id', $_POST);
        header('location: sj6stuList.php');
    }
    else {
        $sql = 'SELECT * FROM `student` where `stu_id`='.$_GET['id'];
        $result = $pdo->query($sql);
        $row = $result->fetch();
        $title = '수강생 수정';
        ob_start();
        include __DIR__.'/../templates/sj6stuForm2.html.php';
        $outString = ob_get_clean();
    }
}
catch (PDOException $e){
    $outString = '<p>오류발생: '.$e->getMessage().$e->getFile().'행 : '.$e->getLine().'</p>';
}
include __DIR__.'/../templates/sj6layout.html.php';