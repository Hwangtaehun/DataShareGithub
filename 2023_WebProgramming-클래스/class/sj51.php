<?php
  class NameAgeClass{
    private $name = '선조이름';
    public $age = 77;
    protected $age2;
    
    public function __construct(){
      $this->name = '기본이름';
      echo '생성자에서 이름은 '.$this->name.'입니다.<br>';
    }
    
    public function __destruct(){
      echo '소멸자 실행';
    }
    
    public function output(){
      echo '이름은 '.$this->name.', 나이는'.$this->age.'<br>';
    }
    
    public function setNameAge(string $name, int $age){
      $this->name = $name;
      $this->age = $age;
    }
    
    public function getName(){
      return $this->name;
    }
    
    final public function globalTest(){
      global $age;
      echo 'global $age = '.$age.'<br>';
    }
  }
  
  $age = 111;
  $nAge1 = new NameAgeClass();
  $nAge1->age = 111;
  //$nAge1->name = 'aaa';
  $nAge1->setNameAge('sejong', 33);
  //$nAge1->setNameAge('computer', 'aa');
  echo 'getName() = '.$nAge1->getName().'<br>';
  $nAge1->output();
  $nAge1->globalTest();
  $nAge2 = $nAge1;
  $nAge1->setNameAge('computer', 20);
  $nAge2->output();
