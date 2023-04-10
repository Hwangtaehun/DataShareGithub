<!DOCTYPE html>
<html lang="ko">
  <head>
    <meta charset="utf-8"> <title>php 예제</title>
  </head>
  <body>
    <h2>File 사용</h2>
    <?php
      $file_name = './test1.txt';
      $exist = file_exists($file_name);
      echo ('exist = '.$exist.'<br>');
      if(!$exist){
        echo($file_name.' File이 없습니다.<br>');
        exit;
      }
      $data = file($file_name);
      $cnt = count($data);
      echo '<p>'.$file_name.' 의 내용 ('.$cnt.' 행 ) <br>';
      for($i=0; $i < $cnt; $i++){
        echo($i.'행 : '.$data[$i].'<br>');
      }
      echo '</p>';
      
      if(!($file=fopen($file_name,'rw'))){
        echo($file_name.' file not found !!');
      }
      else{
        $data = fread($file,11);
        echo('10 Byte만 출력<br>'.$data.'<br>');
        fclose($file);
      }
      
      if(!$file=fopen($file_name,'rb')){
        echo('file not found');
      }
      else{
        $fSize = filesize($file_name);
        echo ' File 크기는 '.$fSize.' 입니다.<br>';
        echo '----- fpassthru로 출력 ----<br>';
        fpassthru($file);
      }
    ?>
  </body>
</html>
