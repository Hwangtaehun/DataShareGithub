using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corutine : MonoBehaviour //코루틴을 사용하면 유지보수가 쉬움
{
    public bool isDelay;
    public float delayTime = 5.0f;
    public float accumTime;
    private float interface_value = 0.0f;
    private int counter = 0;

    private void Update()
    {
        ++counter;

        if (Input.GetKeyDown(KeyCode.A))
        {
            interface_value = interface_value + 1.0f;
            Debug.Log(interface_value);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isDelay == false)
            {
                isDelay = true;
                Debug.Log("HP가 50 회복 되었습니다.");
                //StartCoroutine("Drink(interface_value)");
                StartCoroutine(Drink(interface_value));
            }
            else
            {
                Debug.Log("아직 포션을 사용할 수 없습니다. ");

            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            StopCoroutine("Drink");
        }

        //if(counter % 100 == 0) Debug.Log("카운터" + counter); 
    }
    IEnumerator Drink(float test_value)
    {
        Debug.Log("코루틴시작");
        //yield return new WaitForSeconds(5.0f);
        //yield return new WaitForEndOfFrame(); //쿨타임의미 없음
        //yield return new WaitForFixedUpdate(); //한 프레임 넘어가서 다음 프레임에서 실행

        //다음 프레인 바로 시작 
        //yield return null;

        //바로 종료 (밑에 코드 실행 안됨) 
        //yield break; 

        //Debug.Log("코루틴이 받은 값" + test_value);
        yield return new WaitUntil(() => test_value > 3); //중간에 조건이 변경이 안됨

        Debug.Log("코루틴 안 변수 출력" + test_value);
        isDelay = false;
    }
}
