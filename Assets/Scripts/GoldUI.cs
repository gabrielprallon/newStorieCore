using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Articy;


public class GoldUI : MonoBehaviour {
    private Text m_Text = null;
	// Use this for initialization
	void Start () {
        m_Text = GetComponent<Text>();
        
	}
	
	// Update is called once per frame
	void Update () {
        m_Text.text = Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.SVar.m_Gold.ToString();
    }
}
