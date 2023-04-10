<!DOCTYPE html>
<html lang = "ko">
  <head><meta charset="utf-8"><title>Form Tag 사용</title></head>
  <body>
    <h2>hidden, radio, check 사용</h2>
    <?php
      $page = htmlspecialchars($_POST['page'], ENT_QUOTES, 'UTF-8');
      $passwd = $_POST['password'];
      $grp1 = $_POST['group1'];
      
      $chk1 = isset($_POST['chk1']) ? $_POST['chk1'] : '';
      $chk2 = !empty($_POST['chk2']) ? $_POST['chk2'] : '';
      $chk = $_POST['chk'] ?? '';
      $program = $_POST['pgm'];
      $txtvalue = $_POST['txtcmt'];
      
      
      echo '<p>Form에서 전달 된 내용 입니다.</p>';
      echo '<p>hidden으로 전달 된 page = '. $page .'입니다. <br>';
      echo 'password = '. $passwd .' 입니다. </p>';
      
      echo '<p>radio 선택 내용은 '.$grp1.'입니다.</p>';
      echo '<p>chkeck Box에 선택된 내용은<br>';
      if($chk1)
        echo $chk1.'선택 함. <br>';
      else
        echo '선택 안됨(필기). <br>';
      if($chk2)
        echo $chk2.'선택 함. <br>';
      else
        echo '선택 안됨(실기). <br>';
       
      echo '<p> 과정선택 3에서 선택된 내용 <br>';
      if($chk){
        foreach($chk as $value){
          echo $value. '과정 선택 됨<br>';
        }
        echo '</p>';
      }
      echo '<p>List에서 선택된 내용은'.$program.'입니다.</p>';
      echo '<p>textarea의 내용입니다.<br>';
      echo $txtvalue.'</p>';
    ?>
  </body>
</html>