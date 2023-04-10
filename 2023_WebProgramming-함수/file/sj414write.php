<!DOCTYPE html>
<html lang="ko">
    <head>
        <meta charset="utf-8">
        <title>Layout 연습</title>
        <link type="text/css" rel="stylesheet" href="..\css\SjLayout.css" />
    </head>
    <body>
        <header>
            <h1>방 명 록 기록</h1>
        </header>
        <?php
          $data_dir='./data';
        //   echo '<p> $data_dir = '.$data_dir.'</p>';
        //   if(opendir("$data_dir")){
        //     echo '폴더를 열 수 없습니다.';
        //   }
          $dir = opendir("$data_dir");
          while ($temp=readdir($dir)) {
            if (($temp != '.')&&($temp != '..')) {
                $filename[] = $temp;
            }
          }
          closedir($dir);

          $cnt = count($filename) + 1;
          echo 'cnt = '.$cnt.'<br>';
          $name     = htmlspecialchars($_POST['user_name'],     ENT_QUOTES, 'UTF-8');
          $password = htmlspecialchars($_POST['user_password'], ENT_QUOTES, 'UTF-8');
          $email    = htmlspecialchars($_POST['user_email'],    ENT_QUOTES, 'UTF-8');
          $comment  = htmlspecialchars($_POST['user_comment'],  ENT_QUOTES, 'UTF-8');
          /*
          echo '<p> 이름 = '.$name.'<br>';
          echo '비밀번호 = '.$password.'<br>';
          echo '이메일 = '.$email.'<br>';
          echo '남긴글 = '.$comment.'</p>';
          $check = "$data_dir/$cnt";
          echo '<p>check = '.$check.'</p>';
          */
          $fp = fopen("$data_dir/$cnt", "w");
          fwrite($fp, "$name\n$password\n$email\n$comment");
          fclose($fp);
          echo '<dir class = "form_class"> 방명록에 기록 됨.'.
               '<a href=sj414.html>입력 화면으로 </a>'.
               '<a href=sj414list.php>내용보기화면으로</a></dir>';
        ?>
    </body>
</html>