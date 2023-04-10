<?php
  interface TestInterface1 {
    //private $name;
    const SJ = '세종컴퓨터';
    public function setNameAge(string $name, int $age);
    public function output();
  }
  
  interface TestInterface2{
    public function getName();
  }
  
  class testClass1 implements TestInterface1{
    private $name;
    private $age;
    public function setNameAge(string $name, int $age){
      $this->name = $name;
      $this->age = $age;
    }
    public function output(){
      echo '자손1 에서 '.$this->name.', '.$this->age.'<br>';
    }
  }
  
  class testClass2 implements TestInterface1, TestInterface2 {
    private $name;
    private $age;
    
    public function getName() {
      return $this->name;
    }
    
    public function setNameAge(string $name, int $age){
      $this->name = $name;
      $this->age = $age;
    }
    
    public function output(){
      echo '자손2 에서 '.$this->getName().', '.$this->age.'<br>';
    }
  }
  
  $obj1 = new testClass1();
  $obj1->setNameAge('sejong' ,33);
  $obj1->output();
  $obj2 = new testClass2();
  $obj2->setNameAge('computer', 22);
  $obj2->output();
  echo '이름 = '.$obj2->getName().', '.testClass2::SJ;
