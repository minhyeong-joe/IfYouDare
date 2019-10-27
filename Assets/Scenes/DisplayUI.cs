using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayUI : MonoBehaviour
{
    public GameObject myPanel;
    public Text myText;
    bool displayInfo = false;
    public float fadeTime;

    void Start() 
    {
    }

    void Update() {
        OpenPanel();
    }

    void OnTriggerEnter()
    {
        displayInfo = true;
    }

    void OnTriggerExit()
    {
        displayInfo = false;
    }

    void OpenPanel()
    {
        if (displayInfo)
        {
            myPanel.SetActive(true);
            Animator animator = myPanel.GetComponent<Animator>();

            animator.SetBool("open", true);
            myText.color = Color.Lerp(myText.color, Color.black, fadeTime * Time.deltaTime);
        }
        else
        {
            myPanel.SetActive(false);
            Animator animator = myPanel.GetComponent<Animator>();

            animator.SetBool("open", false);
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);

        }
    }
}
