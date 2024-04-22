using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Manager_script : MonoBehaviour
{
    [SerializeField] private TMP_InputField Id_input;
    [SerializeField] private TMP_InputField Pw_input;
    [SerializeField] private Slider Slider_value;

    public void UI_ButtonText()
    {
        Debug.Log("HI I am button");
    }

    public void UI_Input_Name_Check()
    {
        if (Id_input.text == "name")
        {
            Debug.Log("Welcome to the game");
        }
        else
        {
            Debug.Log("ID Failure");
        }
    }

    public void UI_Input_Pw_Check()
    {
        if(Pw_input.text == "123456")
        {
            Debug.Log("Welcome to the game");
        }
        else
        {
            Debug.Log("PW Failure");
        }
    }

    public void UI_Slider_Change()
    {
        Debug.Log("Slider Changed" + Slider_value.value);
    }
}
