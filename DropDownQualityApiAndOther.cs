using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownQualityApiAndOther : MonoBehaviour
{
    public TMPro.TMP_Dropdown QualityDropDown;
    public string qualityPlayerPrefs;
    public string vsyncPlayerPrefs;

    void Start()
    {
        
        if(PlayerPrefs.GetInt("QualityLevelDropDown") == 0)
        {
            QualitySettings.SetQualityLevel(5, true);
            QualityDropDown.value = 0;
        }
        if (PlayerPrefs.GetInt("QualityLevelDropDown") == 1)
        {
            QualitySettings.SetQualityLevel(2, true);
            QualityDropDown.value = 1;
        }
        if (PlayerPrefs.GetInt("QualityLevelDropDown") == 2)
        {
            QualitySettings.SetQualityLevel(5, true);
            QualityDropDown.value = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(QualityDropDown.value == 2)
        {
            QualitySettings.SetQualityLevel(0, true);
            PlayerPrefs.SetInt("QualityLevelDropDown", 2);
        }
        if (QualityDropDown.value == 1)
        {
            QualitySettings.SetQualityLevel(2, true);
            PlayerPrefs.SetInt("QualityLevelDropDown", 1);
        }
        if (QualityDropDown.value == 0)
        {
            QualitySettings.SetQualityLevel(5, true);
            PlayerPrefs.SetInt("QualityLevelDropDown",0);
        }

        

    }
}
