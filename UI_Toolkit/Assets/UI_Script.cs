using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements; 


public class UI_Script : MonoBehaviour
{

    public UIDocument _doc;
    private Button _TestButton;
    private Slider _TestSlider;
    private Toggle _TestToggle; 

    void Awake()
    {
        //_doc = GetComponent<UIDocument>();
        _TestButton = _doc.rootVisualElement.Q<Button>("TestButton");
        _TestSlider = _doc.rootVisualElement.Q<Slider>("TestSlider");
        _TestToggle = _doc.rootVisualElement.Q<Toggle>("TestToggle");

        _TestButton.clicked += TestButtonClicked;

        /*
        _TestSlider.RegisterValueChangedCallback(v => {
            var oldValue = v.previousValue;
            var newValue = v.newValue;
            Debug.Log("Hello"); 
        });
        */

        _TestSlider.RegisterValueChangedCallback(x => { Debug.Log("Hello2");  });

        _TestToggle.RegisterValueChangedCallback(x => { Debug.Log("Hello3"); }); 
        


    }

    private void TestButtonClicked()
    {
        Debug.Log("Test Button Clicked"); 

    }

}
