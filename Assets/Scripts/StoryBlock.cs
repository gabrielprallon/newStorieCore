using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryBlock : MonoBehaviour {

    [SerializeField]
    private Text m_TextField;
    [SerializeField]
    private Image m_SpriteField;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //add text to the block
    public bool SetText(string text)
    {
        if (m_TextField == null) return false;
        m_TextField.gameObject.SetActive(true);
        m_TextField.text = text;
        return true;
    }
    //add a image to the block
    public bool SetImage(Sprite img)
    {
        if (m_SpriteField == null) return false;
        m_SpriteField.gameObject.SetActive(true);
        m_SpriteField.sprite = img;
        return true;
    }

    // hide all blocks
    public void Hide()
    {
        m_SpriteField.gameObject.SetActive(false);
        m_TextField.gameObject.SetActive(false);

    }
}
