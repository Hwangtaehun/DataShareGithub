<!doctype html>
<html>
  <head>
    <meta charset = "utf-8"/>
    <title>Message</title>
  </head>
  <body>
    <?php
      if(isset($strMsg)):
        echo $strMsg;
      else:
        echo '성공1<br>';
      endif;
    ?>
  </body>
</html>
