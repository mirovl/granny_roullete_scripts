using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextWaiter : MonoBehaviour
{
    public GameObject text01;
    public GameObject text02;
    public Animator text02anim;
    public string animationhide;
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(aftertext());
    }
    IEnumerator aftertext()
    {
        yield return new WaitForSeconds(2);
        text01.SetActive(false);
        text02.SetActive(true);
        yield return new WaitForSeconds(3);
        text02anim.Play(animationhide);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Menu");
    }
    
}
