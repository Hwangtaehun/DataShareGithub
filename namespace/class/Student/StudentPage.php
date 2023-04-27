<?php
namespace Student;
class StudentPage
{
    private $m_uri;

    public function __construct($uri){
        $this->m_uri = $uri;
    }

    public function makePage(){
      include __DIR__.'/../../includes/DbConnect.php';
      //include __DIR__.'/../classes/TableManager.php';
      $stuTable   = new \SjFrame\TableManager($pdo, 'student', 'stu_no');
      $scoreTable = new \SjFrame\TableManager($pdo, 'score', 'sc_id');

      if($this->m_uri == '' || $this->m_uri == 'index.php'){
        $this->m_uri = 'student/home';
      }
      $uris = explode('/', $this->m_uri);
      $funcName = $uris[1];
      $className = '\Student\Controllers\\'.ucfirst($uris[0]).'Controller';
      // $className = ucfirst($uris[0]).'Controller';
      // include __DIR__.'/../controllers/'.$className.'.php';
      $controller = new $className($stuTable, $scoreTable);
      $page = $controller->$funcName();
      return $page;
    }
}
