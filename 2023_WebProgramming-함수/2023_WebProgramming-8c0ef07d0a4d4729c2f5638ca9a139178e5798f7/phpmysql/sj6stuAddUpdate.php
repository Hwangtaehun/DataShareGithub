<?php
  include_once __DIR__.'/../includes/Dbconnect.php';
  include_once __DIR__.'/../includes/UserFunctions.php';
  
  try{
    if(isset($_POST['stu_id'])){
      if($_POST['stu_id'] == ''){
        insertData($pdo, 'student', $_POST);
      }
      else {
        updateData($pdo, 'student', 'stu_id', $_POST);
      }
      header('location: sj6stuList.php');
    }
    else{
      if(isset($_GET['id'])){
        // $sql = 'SELECT * FROM `student` where `stu_id`='.$_GET['id'];
        // $result = $pdo->query($sql);
        // $row = $result->fetch();
        
        //$row = selectStu($pdo, $_GET['id']);
        $row = selectData($pdo, 'student', 'stu_id', $_GET['id']);
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
