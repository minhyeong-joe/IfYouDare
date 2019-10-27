using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaperText : MonoBehaviour
{
    public Transform player;
    public bool GuiOn;
    public string Text = "8 Days Spent in Italy & France\r\n3 Days Spent in US & Guam\r\nNow Off To Russia & Korea";
    public Rect BoxSize = new Rect(0, 0, 200, 100);
    public GUISkin customSkin;
    public bool hasPlayer = false;

     void OnTriggerEnter()
     {

         GuiOn = true;
     }


     void OnTriggerExit()
     {
         GuiOn = false;
     }

    void OnGUI()
    {

        if (customSkin != null)
        {
            GUI.skin = customSkin;
        }

        if (GuiOn == true)
        {
            // Make a group on the center of the screen
            GUI.BeginGroup(new Rect((Screen.width - BoxSize.width) / 2, (Screen.height - BoxSize.height) / 2, BoxSize.width, BoxSize.height));
            // All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.

            GUIStyle myStyle = new GUIStyle();
            myStyle.normal.textColor = Color.blue;
            GUI.Label(BoxSize, Text, myStyle);

            // End the group we started above. This is very important to remember!
            GUI.EndGroup();

        }


    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 2.5f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }
        if (hasPlayer && OVRInput.Get(OVRInput.Button.One))
        {
            GuiOn = true;
        }
        else
        {
            GuiOn = false;
        }*/

    }
}