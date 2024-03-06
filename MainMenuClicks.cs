using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuClicks : MonoBehaviour
{
    public Button buttonStart;
    public Button buttonQuit;
    public GameObject loadingbackground;
    public TMPro.TMP_Text text_loading;
    public double a = 0;
    void Start()
    {
        buttonStart.onClick.AddListener(Startbutton);
        buttonQuit.onClick.AddListener(Quit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Startbutton()
    {
        loadingbackground.SetActive(true);
        StartCoroutine(text_and_load());
    }
    public IEnumerator text_and_load()
    {
        while (a <= 5)
        {
            text_loading.text = "Loading.";
            a = a + 0.2;
            yield return new WaitForSeconds(1);
            a = a + 0.2;
            text_loading.text = "Loading..";
            yield return new WaitForSeconds(1);
            a = a + 0.2;
            text_loading.text = "Loading...";
            yield return new WaitForSeconds(1);
            //a = a + 0.1;
        }
        if(a >= 5)
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }
}
