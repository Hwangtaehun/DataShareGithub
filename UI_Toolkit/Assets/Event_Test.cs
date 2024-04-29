using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.Events;
using System;


public class Event_Test : MonoBehaviour
{
    public UnityEvent OnSpacePressed; 

    // Start is called before the first frame update

    public void Call_OnSpacePressed()
    {

        Debug.Log("space pressed"); 

    }

    void Start()
    {
        OnSpacePressed.AddListener(Call_OnSpacePressed);        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (OnSpacePressed != null)
                OnSpacePressed.Invoke(); 

        }

        
    }
}
