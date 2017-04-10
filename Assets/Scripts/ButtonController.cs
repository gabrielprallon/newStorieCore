using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System;

public class ButtonController : MonoBehaviour {


    [SerializeField]
    private Text m_ButtonText;
    [SerializeField]
    private int m_ButtonId;
    [SerializeField]
    private GameController m_GameController;
    private Branch m_CurrentBranch;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        //m_GameController.GenerateStoryBlock(m_ButtonId, m_ButtonText.text);
        m_GameController.GoToBranch(m_CurrentBranch);
    }

    public void UpdateButton(Branch newBranch)
    {
        m_CurrentBranch = newBranch; 
        m_ButtonText.text = ((IObjectWithText)m_CurrentBranch.Target).Text; // Titulo: m_CurrentBranch:m_CurrentBranch.DefaultDescription
    }
}
