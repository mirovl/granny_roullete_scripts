using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wait : MonoBehaviour
{
    public Animator animator1;

    public int n;

    public Button button;


    public IEnumerator mysdsd()
    {
        yield return new WaitForSeconds(n);
        animator1.Play("winning");
    }
    public void kkd()
    {
        StartCoroutine(mysdsd());
    }
}
