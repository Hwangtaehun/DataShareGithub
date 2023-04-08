<?php
class TableManager
{
    function myQuery($pdo, $sql, $param = []){
        $stmt = $pdo->prepare($sql);
        $stmt->execute($param);
        return $stmt;
    }

    function insertData($pdo, $table, $param)
    {
        $sql = 'INSERT INTO `'.$table.'` SET ';
        foreach($param as $key=>$value){
            $sql .= '`'.$key.'`= :'.$key.', ';
        }
        $sql = rtrim($sql, ', ');
        $this->myQuery($pdo, $sql, $param);
    }

    function deleteData($pdo, $table, $keyField, $id)
    {
        $param = [':id'=>$id];
        $sql = 'DELETE FROM `'.$table.'` WHERE `'.$keyField.'`=:id';
        $this->myQuery($pdo, $sql, $param);
    }

    function updateData($pdo, $table, $keyField, $param){
        $sql = 'UPDATE`'.$table.'`SET ';
        foreach($param as $key=>$value){
            $sql .= '`'.$key.'`= :'.$key.', ';
        }
        $sql = rtrim($sql, ', ');
        $sql .= ' WHERE `'.$keyField.'`= :'.$keyField;
        $this->myQuery($pdo, $sql, $param);
    }
}