<!doctype html>
<html lang="ko">
  <head>
    <meta charset="utf-8">
    <title> �޸� ����</title>
  </head>
  <body>
    <?php
      $content = htmlspecialchars($_POST['content'], ENT_QUOTES, 'UTF-8');
      
      if(!$content){
        echo('<script type = "text/javascript">
              window.alert("�޸� ������ �Է��ϼ���.");
              history.go(-1)
              </script>');
        exit;
      }
      
      if($fp = fopen('memo1.dat','a')){
        fwrite($fp, $content."\n");
        fclose($fp);
        echo('<script type="text/javascript">
              location = "sj413.php";
              </script>');
      }
      else{
        echo(' <script type="text/javascript">
                window.alert("��� file�� �̻��ϳ�.")
                history.go(-1)
                </script>');
      }
    ?>
  </body>
</html>
