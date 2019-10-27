using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputClick : MonoBehaviour
{
    public string input;
    public GameObject[] fields;

    static string combination = "";
    const string KEYCODE = "7412";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if(input == "reset")
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

    void resetFields()
    {
        print("reset");
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
        }
        else
        {
            print("WRONG");
        }
        resetFields();
    }
}
