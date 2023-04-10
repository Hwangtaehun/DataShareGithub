<!doctype html>
<html>
    <head>
        <meta charset = "utf-8">
        <link rel="stylesheet" href="../css/sj6form.css">
        <title><?=$title?></title>
    </head>
    <body>
        <header>
            <h1><?=$title?></h1>
        </header>
        <nav>
            <ul>
                <li><a href="sj6index.php">홈</a></li>
                <li><a href="sj6stuList.php">수강생 현황</a></li>
                <li><a href="sj6stuAddUpdate.php">수강생 입력</a></li>
                <li><a href="sj6scoreList.php">점수 보기</a></li>
                <li><a href="sj6scoreAddUpdate.php">점수 입력</a></li>
            </ul>
        </nav>
        <main>
            <?= $outString ?>
        </main>
        <footer>
            <h4>세종 컴퓨터 학원 충북 청주시 사창동</h4>
        </footer>
    </body>
</html>