<?php

$title = '성적 관리';

ob_start();

include __DIR__.'/../templates/sj6home.html.php';

$outString  = ob_get_clean();

include __DIR__.'/../templates/sj6layout.html.php';