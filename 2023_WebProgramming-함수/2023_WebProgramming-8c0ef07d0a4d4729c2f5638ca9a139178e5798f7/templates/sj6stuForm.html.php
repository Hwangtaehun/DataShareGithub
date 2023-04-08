<form action="" method ="post">
    <fieldset id = "form_fieldset">
        <legend>아래 내용을 입력하세요.</legend>
        <ul>
            <li><label for="id_no">번호</label>
                <input type="text" name="stu_no" id="id_no" value=""></li>
            <li><label for="id_name">이름</label>
                <input type="text" name="stu_name" id="id_name" value=""></li>
            <li><label for="id_addr">주소</label>
                <input type="text" name="stu_address" id="id_addr" value=""></li>
            <li><label for="id_bday">생일</label>
                <input type="text" name="stu_birthday" id="id_bday" value=""></li>
        </ul>
        <div class = "form_class">
            <input type="submit" value="입 력">
            <input type="reset" value="지우기">
        </div>
    </fieldset>
</form>