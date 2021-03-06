﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using CharacterH;
using LifeBarHandler;

public class GameController : MonoBehaviour {

    [SerializeField]
    private GameObject m_storyScreen;
    [SerializeField]
    private GameObject m_characterScreen;
    /*
    [SerializeField]
    private GameObject m_buttonOne;
    [SerializeField]
    private GameObject m_buttonTwo;
    [SerializeField]
    private GameObject m_buttonThree;
    */

    [SerializeField]
    private List<GameObject> m_Buttons;
    
    [SerializeField]
    private Sprite m_CharButton;
    [SerializeField]
    private Sprite m_StoryButton;
    [SerializeField]
    private GameObject m_ScrollView;

    [SerializeField]
    private GameObject m_buttonCharacter;

    //variaveis de tempo
    private DateTime lastEnergy;
    private DateTime currentTime;
    private DateTime difference;
    //variaveis de energia
    [Header("Energy")]
    [SerializeField]
    private int m_characterEnergy = 10;
    [SerializeField]
    private int m_maxEnergy = 10;
    [SerializeField]
    private int m_energyIncrementPerTime = 1;
    [Range(0f, 60f)]
    [SerializeField]
    private float m_secsToNextEnergy = 60f;
    [SerializeField]
    private float m_timeSinceLastEnergy = 0f;
    [SerializeField]
    private GameObject m_storyBlockPrefab;
    [SerializeField]
    private RectTransform ScrollContainer;
    [Range(0f, 600f)]
    [SerializeField]
    private float heightIncrementer = 150f;
    [SerializeField]
    private ScrollRect autoScroll;
    [Range(0f, 2000f)]
    [SerializeField]
    private float scrollSpeed = 1000f;
    private bool m_characterScreenOn = false;

    private List<StoryBlock> storyNodesList;

    private int m_ButtonCounter;
    private CharacterHandler m_CH;
    private HpMpHandler m_LB;

    public List<StoryBlock> StoryNodesList
    {
        get
        {
            return storyNodesList;
        }

        set
        {
            storyNodesList = value;
        }
    }

    /* 
     * ATENÇAO!!!!!!!!!!!!!!!!!
     * O UNITY N CONSEGUE IDENTIFICAR OS LIMITES DAS VARIAVEIS SETADAS PELO ARTICY
     * CRIAR VERIFICADORES PARA CASO AS VARIAVEIS ULTRAPASSEM O CODIGO SETA ELA PRO VALOR CERTO
     * EX: O PLAYER N PODE TER MENOS Q 0 DE HP, CASO O HP - DANO CAUSADO DE <0 O HP PRECISA VIRAR 0
     */
    void Awake()
    {
        energyLoader();
        StoryNodesList = new List<StoryBlock>();

    }

    // Use this for initialization
    void Start() {
        m_CH = GetComponent<CharacterHandler>();
        energyTimeSaving();
        m_LB = GetComponent<HpMpHandler>();
        //m_LB.testc();
        ScrollToBottom();
    }

    // Update is called once per frame
    void Update() {
        if (m_characterScreenOn == false)
        {
            m_CH.CharacterPlaceTimer();
        }
        energyRegen();
        
    }


    //||||||||||||||||||
    //||Screen Manager||
    //||||||||||||||||||

    //Screen change button script 
    public void screenSetActive()
    {
        m_characterScreenOn = !m_characterScreenOn;
        screenChanger();
    }
    //activating one screen while desactivating another
    void screenChanger()
    {
        if (m_characterScreenOn == false)
        {
            m_storyScreen.SetActive(true);
            m_characterScreen.SetActive(false);
            /*for(int i=0; i<=m_ButtonCounter; i++)
            {
                m_Buttons[i].SetActive(true);
            }
            */
            //m_ScrollView.SetActive(true);
            m_buttonCharacter.GetComponent<Image>().sprite = m_CharButton;
            //m_CH.CharacterDestroy();
            
            
            
        }
        else
        {
            m_storyScreen.SetActive(false);
            m_characterScreen.SetActive(true);
            /*for (int i = 0; i <= m_ButtonCounter; i++)
            {
                m_Buttons[i].SetActive(false);
            }
            */
            //m_ScrollView.SetActive(false);
            m_buttonCharacter.GetComponent<Image>().sprite = m_StoryButton;
            m_CH.CharactersActivated();
            //m_CH.CharacterSpawn();
        }


    }

    //||||||||||||||||||
    //||Energy Scripts||
    //||||||||||||||||||


   //load the previous energy and timestamp
    void energyLoader()
    {
        // check if there is a previous time stamp and if not create a new one
        if (!PlayerPrefs.HasKey("energyDate"))
        {
            PlayerPrefs.SetString("energyDate", System.DateTime.Now.ToBinary().ToString());
        }
        // check how many energy the player has on the last login
        if (!PlayerPrefs.HasKey("playerEnergy"))
        {
            PlayerPrefs.SetInt("playerEnergy", m_characterEnergy);
        }
    }

   //compare time stamps to add the energy generated since the last login
    void energyTimeSaving()
    {
        // get the current timestamp
        currentTime = DateTime.Now;

        // load the saved time stamp
        long energyDate = Convert.ToInt64(PlayerPrefs.GetString("energyDate"));
        // load the current energy
        m_characterEnergy = PlayerPrefs.GetInt("playerEnergy");
        // convert the timestamp to binary
        lastEnergy = DateTime.FromBinary(energyDate);

        // check the difference between timestamps
        TimeSpan difference = currentTime.Subtract(lastEnergy);
        //add the generated energy
        if (difference.TotalSeconds > m_secsToNextEnergy)
        {
            if (m_characterEnergy < m_maxEnergy)
            {
                energyCharger((int)difference.TotalSeconds % (int)m_secsToNextEnergy);
            }
        }
    }

    // generate energy when playing
    void energyRegen()
    {
        m_timeSinceLastEnergy += Time.deltaTime;
        if (m_timeSinceLastEnergy >= m_secsToNextEnergy)
        {
            if (m_maxEnergy > m_characterEnergy)
            {
                m_timeSinceLastEnergy = 0f;
                energyCharger();
            }
        }
    }
    // energy incrementer
    public void energyCharger(int multi = 1)
    {
        m_characterEnergy += m_energyIncrementPerTime * multi;
        lastEnergy = System.DateTime.Now;

    }

    // consume energy
    public void energyRequired()
    {
        m_characterEnergy--;
    }

    // save the last timestamp before loging out
    void OnApplicationQuit()
    {
        PlayerPrefs.SetString("energyDate", lastEnergy.ToBinary().ToString());
        PlayerPrefs.SetInt("playerEnergy", m_characterEnergy);
    }

    //get button text and create a storyblock
    public void GenerateStoryBlock(int ID, string text)
    {

        GameObject m_StoryNode = Instantiate(m_storyBlockPrefab);
        m_StoryNode.GetComponent<StoryBlock>().SetText(text);
        m_StoryNode.GetComponent<RectTransform>().SetParent(ScrollContainer.transform, false);
        m_StoryNode.GetComponent<RectTransform>().localPosition = new Vector3(0, ScrollContainer.sizeDelta.y * (-1), 0);
        ScrollContainer.sizeDelta = new Vector2(ScrollContainer.sizeDelta.x, ScrollContainer.sizeDelta.y + heightIncrementer);
        m_StoryNode.GetComponent<RectTransform>().offsetMax = new Vector2(0, m_StoryNode.GetComponent<RectTransform>().offsetMax.y);
        StoryNodesList.Add(m_StoryNode.GetComponent<StoryBlock>());
        automaticScroll();
        
    }
    //scroll down for each chosen choice
    void automaticScroll()
    {
        autoScroll.velocity = new Vector2(0f, scrollSpeed);
    }
    //scroll to botton after load all choices
    void ScrollToBottom()
    {
        m_ScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 0.5f;
    }
    //turn on the number of buttons based on the number of choises the player has to make
    public void SetButton (IList<Branch> aBranches)
    {
        for (int i = 0; i < m_Buttons.Count; i++)
            m_Buttons[i].SetActive(false);
        for (int i = 0; i < aBranches.Count; i++)
        {
            m_Buttons[i].SetActive(true);
            m_Buttons[i].GetComponent<ButtonController>().UpdateButton(aBranches[i]);
            m_ButtonCounter = i;
        }
    }
    //load the next story branch
    public void GoToBranch(Branch nextBranch)
    {
        
        GetComponent<DialogueHandler>().GotToBranch(nextBranch);

        
    }
    //armazenar uma lista de branch reconstruir os botÕes

    void Save()
    {

    }
}
