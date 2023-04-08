<!doctype html>
<html>
  <head>
    <meta charset = "utf-8"/>
    <title>Message</title>
  </head>
  <body>
    <?php if (isset($strMsg) ): ?>
      <p>
      <?php echo $strMsg; ?>
      <?= $strMsg; ?>
      </p>
    <?php else: ?>
      <p>
      성공2<br>
      </p>
    <?php endif; ?>
  </body>
</html>
