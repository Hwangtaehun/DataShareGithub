<!DOCTYPE html>
<html>
    <head> <title>if 예제</title> </head>
    <body>
        <h2>if 문 연습</h2>
    <?php
     $a = 0;
     if($a){
        echo '<p>if($a ='.$a.' --> 참이네유 ...</p>';
     }
     else {
        echo '<p>$a = '.$a.'--> 거짓인디 ~~.</p>';
     }
     if($a < 0){
      echo '<p>if($a = 음수네유...</p>';
     }
     elseif($a > 0){
      echo '<p>if($a = 양수인가봐...</p>';
     }
     else{
      echo '<p>$a = 나는 영이다.</p>';  
     }
     if ($a<0): echo '<p>$a = 또 음수네유...</p>';
     elseif ($a>0): echo '<p>$a = 또 양수인가봐...</p>';
     else: echo '<p>$a = 나는 아직도 영이다.</p>';
     endif;
     $a = 10;
     $b = ($a > 0) ? '양수' : '음수';
     echo '<p>$b =' .$b. '</p>';
     $a = 'sejong';
     if($a == 'sejong'){
        echo '<p>세종이네</p>';
     }
     else{
        echo '<p>세종이 아니네</p>';
     }
     $a = 10;
     if($a>1 && $a <= 100)
     {
        ?>
            <h2>
                a는 1 부터 100 사이의 수
            </h2>
        <?php
     }
     else {
        echo '<h2>a는 범위의 수가 아님 </h2>';
     }
    ?>
    </body>
</html>