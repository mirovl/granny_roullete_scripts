using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class saveingamename : MonoBehaviour
{
    public TMP_Text textus;
    public string str_name;
    public TMP_Text text02;
    public TMP_Text text03;

    // Update is called once per frame
    void Update()
    {
        str_name = textus.text;
        text02.text = $"Ok {str_name} i wanna know you really wanna play this game?";
        text03.text = $"{str_name}:";
    }
}
