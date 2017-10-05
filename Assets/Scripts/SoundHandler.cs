using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoundHandler : MonoBehaviour {

    [SerializeField]
    private GameObject m_AudioButton;
    [SerializeField]
    //private GameObject m_AudioSource;
	private AudioSource m_AudioSource;
    [SerializeField]
    private GameObject m_SoundMuteImage;
    [SerializeField]
    private GameObject m_SoundOnImage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //change the music volume to 0 or 100
    public void AudioOffAndOnAgain()
    {
		if(m_SoundOnImage.active)
        {
			m_AudioSource.volume = 0f;
			//m_AudioSource.SetActive(false);
            m_SoundMuteImage.SetActive(true);
            m_SoundOnImage.SetActive(false);

            
        }
        else
        {
			m_AudioSource.volume = 1f;
            //m_AudioSource.SetActive(true);
            m_SoundMuteImage.SetActive(false);
            m_SoundOnImage.SetActive(true);
        }
    }

}

