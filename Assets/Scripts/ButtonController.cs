using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonController : MonoBehaviour {


    [SerializeField]
    private Text m_ButtonText;
    [SerializeField]
    private int m_ButtonId;
    [SerializeField]
    private GameController m_GameController;
    

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick()
    {
        m_GameController.GenerateStoryBlock(m_ButtonId, m_ButtonText.text);
    }
}
