<!doctype html>
<html lang="ko">
  <head>
    <meta charset="utf-8"><title>메모장</title>
    <link rel = "stylesheet" href="..\css\form2.css" />
  </head>
  <body>
    <header>
      <h1>1 줄짜리 메모장</h1>
    </header>
    
    <?php
      $fname = './memo1.dat';
      if(!file_exists($fname)){
        $fp = fopen($fname,'w');
        fclose($fp);
      }
      $data = file($fname);
      $cnt = count($data);
      echo '메모의 갯수는 cnt = '.$cnt.'<hr>';
      /*
      for($i = 0; $i < $cnt ;$i++){
        $j = $i + 1;
        echo('<h4>'.$j.'번째 메모 : '.$data[$i].'</h4>');
      }
      */
      
      foreach($data as $key=>$value){
        $i = $key + 1;
        echo('<h4>'.$i.'번째 메모: '.$value.'</h4>');
      }
    ?>
    <hr>
    <form action="sj413write.php" method="post">
      <label for="content1">메모 남기기: </label>
      <input type="text" name="content" id="content1" autofocus="">
      <P><input type="submit" value="메모저장하기"></input></p>
    </form>
  </body>
</html>
