using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//문제점: 업데이트 함수에 많은 코드가 있으면 가독성이 떨어짐, 일정 시간 return하는 것은 코루틴 사용
public class withoutcorutine : MonoBehaviour
{
    public bool isDelay; //false
    public float delayTime = 5.0f;
    public float accumTime;//지역변수

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isDelay == false)
            {
                isDelay = true;//켜짐
                Debug.Log("HP가 50 회복 되었습니다.");
            }
            else
            {
                Debug.Log("아직 포션을 사용할 수 없습니다. ");
            }
        }
        if (isDelay)
        {
            accumTime += Time.deltaTime;
            if (accumTime >= delayTime)
            {
                accumTime = 0.0f;
                isDelay = false;//꺼짐
            }
        }
    }
}
