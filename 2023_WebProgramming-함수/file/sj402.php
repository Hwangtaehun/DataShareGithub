<!DOCTYPE html>
<html lang="ko">
  <head>
    <meta  charset="utf-8">
    <title>php 예제</title>
  </head>
  <body>
    <?php
      $file_name = './test402.txt';
      
      if(!($file=fopen($file_name, 'w'))){
        echo($file_name.' 생성 오류발생!!<br>');
        exit;
      }
      
      $data = '<p>청주에는<br>세종 컴퓨터 학원이<br> 있습니다.</p>';
      $cnt = fwrite($file, $data);
      echo($cnt.'Byte가 '.$file_name.' 로 출력됨<br>');
      fclose($file);
      
      if(!$file=fopen($file_name, 'r')){
        echo('<p>file not found</p>');
      }
      else{
        echo 'File에 기록된 내용은 <br>';
        fpassthru($file);
      }
    ?>
  </body>
</html>
