using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passcodeInput : MonoBehaviour
{
    public string input;
    public GameObject[] fields;
    public AudioSource audioSource;

    static string combination = "";
    const string KEYCODE = "7412";
    private bool touched = false;

    Vector3 defaultPosition;
    Quaternion defaultRotation;
    // Start is called before the first frame update
    void Start()
    {
        defaultPosition = transform.position;
        defaultRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = defaultPosition;
        transform.rotation = defaultRotation;

        if (transform.GetComponent<OVRGrabbable>().isGrabbed)
        {
            touched = true;
        }
        if (touched && !transform.GetComponent<OVRGrabbable>().isGrabbed)
        {
            touched = false;
            if (input == "reset")
            {
                resetFields();
                return;
            }
            int i = 0;
            GameObject emptyField = fields[i];
            while (emptyField.GetComponent<TextMesh>().text != "")
            {
                i++;
                emptyField = fields[i];
            }
            emptyField.GetComponent<TextMesh>().text = input;
            combination = string.Concat(combination, input);
            print(combination);

            if (i >= 3)
            {
                checkCombination();
                return;
            }
            
        }
    }

    void resetFields()
    {
        for (int i = 0; i < 4; i++)
        {
            fields[i].GetComponent<TextMesh>().text = "";
        }
        combination = "";
        print(combination);
    }

    void checkCombination()
    {
        if (combination == KEYCODE)
        {
            print("Correct");
            audioSource.Stop();
        }
        else
        {
            print("WRONG");
        }
        resetFields();
    }
}
