<?php

// function selectAllScore($pdo)
// {
//     $sql = 'SELECT * FROM `student` INNER JOIN `score` ON `student`.`stu_no` = `score`.`sc_no`';
//     //$sql = 'SELECT * FROM `score`';
//     $stmt = myQuery($pdo, $sql);

//     return $stmt->fetchAll();
// }

// function selectAllStu($pdo)
// {
//     $sql = 'SELECT * FROM `student`';
//     $stmt = myQuery($pdo, $sql);

//     return $stmt->fetchAll();
// }

function selectAllData($pdo, $table)
{
    if($table == 'student')
    {
        $sql = 'SELECT * FROM `student`';
    }
    else
    {
        $sql = 'SELECT * FROM `student` INNER JOIN `score` ON `student`.`stu_no` = `score`.`sc_no`';
    }
    $stmt = myQuery($pdo, $sql);
    return $stmt->fetchAll();
}

function myQuery($pdo, $sql, $param = [])
{
    $stmt = $pdo->prepare($sql);

    // foreach($param as $key=>$value){
    //     $stmt->bindValue($key, $value);
    // }
    // $stmt->execute();

    $stmt->execute($param);

    return $stmt;
}

// function insertScore($pdo, $param)
// {
//     // $sql = 'INSERT INTO `score` SET
//     //      `sc_no`       = :sc_no,
//     //      `sc_cpp`      = :sc_cpp,
//     //      `sc_java`     = :sc_java';
//     //$param = [':sc_no'=>$_POST['sc_no'],':sc_cpp'=>$_POST['sc_cpp'],'sc_java'=>$_POST['sc_java']];
//     $sql = 'INSERT INTO `score` SET ';
//     foreach($param as $key=>$value){
//         $sql .= '`'.$key.'`= :'.$key.', ';
//     }
//     $sql = rtrim($sql, ', ');

//     myQuery($pdo, $sql, $param);
// }

function insertData($pdo, $table, $param)
{
    $sql = 'INSERT INTO `'.$table.'` SET ';
    foreach($param as $key=>$value){
        $sql .= '`'.$key.'`= :'.$key.', ';
    }
    $sql = rtrim($sql, ', ');

    myQuery($pdo, $sql, $param);
}

// function updateScore($pdo, $param)
// {
//     //$sql = 'UPDATE `score` SET `sc_no` = :sc_no, `sc_cpp` = :sc_cpp, `sc_java` = :sc_java WHERE `sc_id` = :id';
//     //$param = [':sc_no'=>$_POST['sc_no'], ':sc_cpp'=>$_POST['sc_cpp'], ':sc_java'=>$_POST['sc_java'], ':id'=>$_POST['sc_id']];
//     $sql = 'UPDATE `score` SET ';
//     foreach($param as $key=>$value){
//         $sql .= '`'.$key.'`= :'.$key.', ';
//     }
//     $sql = rtrim($sql, ', ');

//     $sql .= ' WHERE `sc_id`=:sc_id';

//     myQuery($pdo, $sql, $param);
// }

function updateData($pdo, $table, $keyField, $param)
{
    $sql = 'UPDATE`'.$table.'`SET ';
    foreach($param as $key=>$value){
        $sql .= '`'.$key.'`= :'.$key.', ';
    }
    $sql = rtrim($sql, ', ');
    $sql .= ' WHERE `'.$keyField.'`= :'.$keyField;
    
    myQuery($pdo, $sql, $param);
}

// function selectScore($pdo, $id)
// {
//     $param = [':sc_id'=>$id];
//     $stmt = myQuery($pdo, 'SELECT * FROM `score` where `sc_id`= :sc_id', $param);
//     return $stmt->fetch();
// }

// function selectStu($pdo, $id)
// {
//   $param = [':stu_id'=>$id];
//   $stmt = myQuery($pdo, 'SELECT * FROM `student` where `stu_id`= :stu_id', $param);
//   return $stmt->fetch();
// }

function selectData($pdo, $table, $keyField, $id)
{
  $param = [':id'=>$id];
  $stmt = myQuery($pdo, 'SELECT * FROM `'.$table.'` where `'.$keyField.'`= :id', $param);
  return $stmt->fetch();
}

//function deleteScore($pdo, $id)
// {
//     $param = [':sc_id'=>$id];
//     myQuery($pdo, 'DELETE FROM `score` WHERE `sc_id`=:sc_id', $param);
// }

function deleteData($pdo, $table, $keyField, $id)
{
    $param = [':id'=>$id];
    $sql = 'DELETE FROM `'.$table.'` WHERE `'.$keyField.'`=:id';

    myQuery($pdo, $sql, $param);
}

function stuCount($pdo, $no)
{
    // $stmt = $pdo->prepare('SELECT COUNT(*) FROM `student` WHERE `stu_no` = :stu_no');
    // $stmt->bindValue(':stu_no', $no);
    // $stmt->execute();
    $param = [':stu_no'=>$no];
    $stmt = myQuery($pdo, 'SELECT COUNT(*) FROM `student` WHERE `stu_no` = :stu_no', $param);
    $row = $stmt->fetch();
    return $row[0];
}