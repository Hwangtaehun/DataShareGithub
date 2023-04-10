<?php foreach($result as $row): ?>
<fieldset id="fieldset_row">
    <div id="div_row">
        <?=$row['stu_no']?>
        <?=$row['stu_name']?>
        <?=$row['stu_address']?>
        <?=$row['stu_birthday']?>
    </div>
    <form action="sj6stuDel.php" method="post">
            <input type="hidden" name="stu_id" value="<?=$row['stu_id']?>">
            <input type="submit" value="삭제">
            <a href="sj6stuAddUpdate.php?id=<?=$row['stu_id']?>"><input type="button" value="수정"></a>
        </form>
    </fieldset>
</fieldset>
<?php endforeach; ?>