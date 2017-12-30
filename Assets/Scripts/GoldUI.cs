using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Articy;


public class GoldUI : MonoBehaviour {
    private Text m_Text = null;
	// Use this for initialization

    //set the gold value on screen
	void Start () {
        m_Text = GetComponent<Text>();
        
	}
	
	// Update is called once per frame
    //load the gold value from articy
	void Update () {
       m_Text.text = Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.m_ArticyGlobalVariables.m_Gold.ToString();
    }
}
