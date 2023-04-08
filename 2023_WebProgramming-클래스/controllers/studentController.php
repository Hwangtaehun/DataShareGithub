<?php
class StudentController
{
    private $stuTable;
    private $scoreTable;
    
    public function __construct(TableManager $stuTable, TableManager $scoreTable){
        $this->stuTable   = $stuTable;
        $this->scoreTable = $scoreTable;
    }

    public function home(){
        $title = '성적 관리';
        ob_start();
        include __DIR__.'/../templates/sj6home.html.php';
        $outString  = ob_get_clean();

        return ['outString'=>$outString, 'title'=>$title];
    }

    public function scoreList(){
        $scoreResult = $this->scoreTable->selectAll();

        $result=[];
        foreach ($scoreResult as $row) {
            if(!($stuRow = $this->stuTable->selectID($row['sc_no'])))
                $stuRow['stu_name'] = '이름없다';
            $result[] = [
                'sc_id'=>$row['sc_id'],
                'sc_no'=>$row['sc_no'],
                'stu_name'=>$stuRow['stu_name'],
                'sc_cpp'=>$row['sc_cpp'],
                'sc_java'=>$row['sc_java'],
                'sc_av'=>$row['sc_av'],
                'sc_grade'=>$row['sc_grade']
            ];
        }

        $title = '수강생 점수 현황';
        ob_start();
        include __DIR__.'/../templates/sj6scoreList.html.php';
        $outString = ob_get_clean();
        return ['outString'=>$outString, 'title'=>$title];
    }

    public function scoreDelete(){
        $this->scoreTable->deleteData($_POST['sc_id']);
        header('location: sj6scoreList.php');
    }

    public function scoreAddUpdate(){
        if(isset($_POST['sc_id'])){
            if($_POST['sc_id'] == ''){
              if(($this->stuTable->selectID($_POST['sc_no']))){
                $this->scoreTable->insertData($_POST);
              }
              else {
                $title = '점수 입력';
                $outString = '<p> 수강생이 없어요.</p>';
              }
            }
            else {
              $this->scoreTable->updateData($_POST);
            }
            header('location: sj6scoreList.php');
        }
        else{
            if(isset($_GET['id'])){
              $row = $this->scoreTable->selectID($_GET['id']);
              $title2 = ' 수정';
            }
            else{
              $title2 = ' 입력';
            }
            $title = '점수'.$title2;
            ob_start();
            include __DIR__.'/../templates/sj6scoreForm3.html.php';
            $outString = ob_get_clean();
        }
        return ['outString'=>$outString, 'title'=>$title];
    }

    public function stuList(){
        $result = $this->stuTable->selectAll();
        $title = '수강생 현황';
        ob_start();
        include __DIR__.'/../templates/sj6stuList.html.php';
        $outString = ob_get_clean();
        return ['outString'=>$outString, 'title'=>$title];
    }

    public function stuDelete(){
        $this->stuTable->deleteData($_POST['stu_id']);
        header('location: sj6stuList.php');
    }

    public function stuAddUpdate(){
        if(isset($_POST['stu_id'])){
            if($_POST['stu_id'] == ''){
              $this->stuTable->insertData($_POST);
            }
            else {
              $this->stuTable->updateData($_POST);
            }
            header('location: sj6stuList.php');
        }
        else{
            if(isset($_GET['id'])){
              $row = $this->stuTable->selectID($_GET['id']);
              $title2 = ' 수정';
            }
            else{
              $title2 = ' 입력';
            }
            $title = '수강생'.$title2;
            ob_start();
            include __DIR__.'/../templates/sj6stuForm3.html.php';
            $outString = ob_get_clean();
        }
        return ['outString'=>$outString, 'title'=>$title];
    }
}
