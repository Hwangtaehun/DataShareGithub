using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class corutine : MonoBehaviour
{
    public bool isDelay;
    public float delayTime = 5.0f;
    public float accumTime;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(isDelay == false)
            {
                isDelay = true;
                Debug.Log("HP가 50 회복 되었습니다.");
            }
            else
            {
                Debug.Log("아직 포션을 사용할 수 없습니다. ");
            }
        }
        if(isDelay)
        {

            accumTime += Time.deltaTime;
            if(accumTime >= delayTime)
            {

                accumTime = 0.0f;
                isDelay = false; 


            }
        }
    }


}
