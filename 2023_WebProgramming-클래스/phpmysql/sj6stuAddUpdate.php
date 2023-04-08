<?php
  include_once __DIR__.'/../includes/Dbconnect.php';
  //include_once __DIR__.'/../includes/UserFunctions.php';
  include_once __DIR__.'/../class/TableManager.php';

  $stuTable = new TableManager($pdo, 'student', 'stu_id');
  
  try{    
    if(isset($_POST['stu_id'])){
      if($_POST['stu_id'] == ''){
        //insertData($pdo, 'student', $_POST);
        $stuTable->insertData($_POST);
      }
      else {
        //updateData($pdo, 'student', 'stu_id', $_POST);
        $stuTable->updateData($_POST);
      }
      header('location: sj6stuList.php');
    }
    else{
      if(isset($_GET['id'])){
        // $sql = 'SELECT * FROM `student` where `stu_id`='.$_GET['id'];
        // $result = $pdo->query($sql);
        // $row = $result->fetch();
        
        //$row = selectStu($pdo, $_GET['id']);
        $row = $stuTable->selectID($_GET['id']);
        $title2 = ' 수정';
      }
      else{
        $title2 = ' 입력';
      }
      $title = '수강생'.$title2;
      ob_start();
      include __DIR__.'/../templates/sj6stuForm3.html.php';
      $outString = ob_get_clean();
    }
  }
  catch(PDOException $e){
    $outString = '<p>오류발생: '.$e->getMessage().$e->getFile().' 행 : '.$e->getLine().'</p>';
  }
  include __DIR__.'/../templates/sj6layout.html.php';
