<!DOCTYPE html>
<html lang="ko">
    <head>
        <meta charset="utf-8">
        <title>Layout 연습</title>
        <link type="text/css" rel="stylesheet" href="..\css\SjLayout.css" />
    </head>
    <body>
        <header>
            <h1>방 명 록 보기</h1>
        </header>
        <?php
         $data_dir='./data';
         $dir = opendir("$data_dir");
          while ($temp=readdir($dir)) {
            if (($temp != '.')&&($temp != '..')) {
                $filename[] = $temp;
            }
          }
          closedir($dir);

         $cnt = count($filename);
         //echo 'cnt = '.$cnt.$filename[0].'<br>';
         echo '<div class="form_class">방명록 갯수 = '.$cnt.'개 <a href=sj414.html>입력 화면으로 </a></div>';
         
         for ($i=$cnt-1; $i >= 0; $i--) { 
            $data = file("$data_dir/$filename[$i]");
            $tmp = implode('<br>', $data);
            echo '<div id="list"> 방명록 : '.$i.'<br>'.$tmp.'</div>';
         }
        ?>
    </body>
</html>