<?php
  include_once __DIR__.'/../includes/Dbconnect.php';
  //include_once __DIR__.'/../includes/UserFunctions.php';
  include_once __DIR__.'/../class/TableManager.php';

  $stuTable = new TableManager($pdo, 'student', 'stu_no');
  $scoreTable = new TableManager($pdo, 'score', 'sc_id');
  
  try{
    if(isset($_POST['sc_id'])){
      if($_POST['sc_id'] == ''){
        if(($stuTable->selectID($_POST['sc_no']))){
        //if(stuCount($pdo, $_POST['sc_no'])){
          //insertData($pdo, 'score', $_POST);
          $scoreTable->insertData($_POST);
          header('location: sj6scoreList.php');
        }
        else {
          $title = '점수 입력';
          $outString = '<p> 수강생이 없어요.</p>';
        }
      }
      else {
        //updateData($pdo, 'score', 'sc_id', $_POST);
        $scoreTable->updateData($_POST);
        header('location: sj6scoreList.php');
      }
    }
    else{
      if(isset($_GET['id'])){
        //$row = selectScore($pdo, $_GET['id']);
        $row = $scoreTable->selectID($_GET['id']);
        $title2 = ' 수정';
      }
      else{
        $title2 = ' 입력';
      }
      $title = '점수'.$title2;
      ob_start();
      include __DIR__.'/../templates/sj6scoreForm3.html.php';
      $outString = ob_get_clean();
    }
  }
  catch(PDOException $e){
    $outString = '<p>오류발생: '.$e->getMessage().$e->getFile().' 행 : '.$e->getLine().'</p>';
  }
  include __DIR__.'/../templates/sj6layout.html.php';
