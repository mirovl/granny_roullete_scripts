using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActivateConsoleCommand : MonoBehaviour
{
    public Button button_command;
    public Text text_input_field;
    public GameObject granny;
    void Start()
    {
        button_command.onClick.AddListener(start_command);
    }
    public void start_command()
    {
        if(text_input_field.text == "granny_die")
        {
            granny.SetActive(false);
            text_input_field.text = "";
            Debug.Log("granny was died!");

        }
        if (text_input_field.text == "help")
        {
            Debug.Log("granny_die - destroing granny");
        }
    }
}
