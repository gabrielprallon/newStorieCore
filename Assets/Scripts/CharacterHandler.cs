using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy;
namespace CharacterH
{
    public class CharacterHandler : MonoBehaviour
    {
        private static CharacterHandler m_Instance;

        [SerializeField]
        private List<bool> m_CharOnScreen;
        [SerializeField]
        private List<GameObject> m_CharList = new List<GameObject>();
        [SerializeField]
        private List<GameObject> m_CharPrefabs;
        [SerializeField]
        private float m_LastChangeTime;
        [SerializeField]
        private float m_secsToNextChange = 10f;

        private List<Articy.ProjectTheseus.Entity> m_Entities;

        public static CharacterHandler Instance
        {
            get
            {
                return m_Instance;
            }
        }

        void Awake()
        {
            m_Instance = this;
            m_Entities = Articy.Unity.ArticyDatabase.GetAllOfType<Articy.ProjectTheseus.Entity>();
            m_CharOnScreen = new List<bool>();
            for(int i = 0; i < m_CharList.Count; i++)
            {
                m_CharOnScreen.Add(false);
            }
            //m_CharOnScreen.Add(Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.SVar.m_Jorrah);
           // m_CharOnScreen.Add(Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.SVar.m_Minotaur);
        }
        private void Update()
        {
            //m_CharOnScreen[0] = Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.SVar.m_Jorrah;
            //m_CharOnScreen[1] = Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.SVar.m_Minotaur;
            foreach(Articy.ProjectTheseus.Entity entity in m_Entities)
            {
                int charId = entity.getProp("m_CharacterTemplate.m_CharID");
                bool onScreen = entity.getProp("m_CharacterTemplate.m_CharOnScreen");
                if (onScreen != m_CharOnScreen[charId])
                {
                    m_CharOnScreen[charId] = onScreen;
                    CharacterSpawn();
                }
                

            }
        }

        //set the character on when the character screen turns active
        public void CharactersActivated()
        {
            for (int i = 0; i<m_CharOnScreen.Count; i++)
            {
                if(m_CharOnScreen[i])
                {
                    m_CharList[i].SetActive(true);
                }
                else
                {
                    m_CharList[i].SetActive(false);
                }
            }
        }


        //Spawn a new character on the screen
        public void CharacterSpawn()
        {
            int x;
            for (int i=0; i < m_CharList.Count; i++)
            {
                if (m_CharOnScreen[i])
                {
                    Transform slot;
                    do
                    {
                        slot = ScenarioHandler.Instance.GetRandomSlotTransform();
                        m_CharList[i].GetComponent<RectTransform>().parent = slot;
                    } while (!slot || slot.childCount > 1);
                    m_CharList[i].GetComponent<RectTransform>().localPosition = Vector3.zero;
                } else
                {
                    m_CharList[i].transform.parent = null;
                    m_CharList[i].GetComponent<RectTransform>().localPosition = Vector3.zero;
                }
            }
        }

        //controls how often the player position changes
        public void CharacterPlaceTimer()
        {
            m_LastChangeTime += Time.deltaTime;
            if (m_LastChangeTime >= m_secsToNextChange)
            {
                    m_LastChangeTime = 0f;
                    CharacterSpawn();
            }
        }

        //turn off the characters when the history screen turns active
        public void CharacterDestroy()
        {
            for(int i = 0; i < m_CharList.Count; i++)
            {
                m_CharList[i].SetActive(false);
                // Destroy(transform.GetChild(0).m_CharSlots);
            }
        }
    }
}