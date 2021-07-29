using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    public Text titleText;
    public string[] Titles;
    public Button yourButton;

    void Start()
    {
        //Button btn = yourButton.GetComponent<Button>();
        //btn.onClick.AddListener(RandomTitle);
        yourButton.onClick.AddListener(RandomTitle);
    }


    public void RandomTitle()
    {
        titleText.text = Titles[Random.Range(0, Titles.Length)];
        titleText.color = Random.ColorHSV();
    }

    
}
