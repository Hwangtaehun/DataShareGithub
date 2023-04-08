<?php
  include_once __DIR__.'/../includes/Dbconnect.php';
  include_once __DIR__.'/../includes/UserFunctions.php';
  
  try{
    if(isset($_POST['sc_id'])){
      if($_POST['sc_id'] == ''){
        if(stuCount($pdo, $_POST['sc_no'])){
          insertData($pdo, 'score', $_POST);
          header('location: sj6scoreList.php');
        }
        else {
          $title = '점수 입력';
          $outString = '<p> 수강생이 없어요.</p>';
        }
      }
      else {
        updateData($pdo, 'score', 'sc_id', $_POST);
        header('location: sj6scoreList.php');
      }
    }
    else{
      if(isset($_GET['id'])){
        $row = selectScore($pdo, $_GET['id']);
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
