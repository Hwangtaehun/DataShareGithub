using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UI_Manager : MonoBehaviour
{
    public UIDocument _doc;
    private Button _TestButton;
    private Button _TestButton2;
    private Slider _TestSlider;
    private Toggle _TestToggle;

    void Start()
    {
        _TestButton  = _doc.rootVisualElement.Q<Button>("Test_Button");
        _TestButton2 = _doc.rootVisualElement.Q<Button>("Test_Button2");
        _TestButton.clicked  += TestButtonClicked; //_TestButton.clicked: µ®∏Æ∞‘¿Ã∆Æ
        //_TestButton.clicked += character.Die;
        _TestButton2.clicked += TestButtonClicked2;
    }

    private void TestButtonClicked()
    {
        Debug.Log("Test Button Click");
    }

    private void TestButtonClicked2()
    {
        Debug.Log("Test Button2 Click");
    }
}
