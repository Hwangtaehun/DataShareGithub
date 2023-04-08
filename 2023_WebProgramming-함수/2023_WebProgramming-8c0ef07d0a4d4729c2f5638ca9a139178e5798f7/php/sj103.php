<!DOCTYPE html>
<html lang = "ko">
  <head>
    <meta charset = "utf-8">
      <title>php 예제 3</title>
  </head>
    <meta charset = "utf-8">
  <body>
    <h2>echo, print test</h2>
    <?php
    echo("<p>echo에 괄호 사용.<br>");
    echo "괄호 없이 사용<br>";
    echo '단일 인용부호 사용<br>';
    echo " echo는 여러 줄에
     사용이 가능합니다.<br>";
    echo " echo는 여러 줄에 " .
    "사용이 가능 합니다.</p>";
    
    $var = 123;
    echo "<p>php 변수 var = $var <br>";
    echo 'php 변수 test var = $var <br>';
    echo 'php 변수 test var = ' .$var . '<br>';
    echo "php 변수 test \$var = $var <br>";
    echo 'sejong\'s sejong"s <br>';
  
    print '<p>print 괄호 생략<br>';
    printf ('printf는 괄호 생략 못함<br>');
    printf('2 진수=%b, 10진수=%d, 문자=%c, 실수=%10.2f<br>', 15, 123, 65, 12.57);
    print('end</p>');
    exit;
    ?>
  <h2> exit 다음은 어떻게 될까?<h2>
  <?
    echo '<p>php 연습</p>';
  ?>
