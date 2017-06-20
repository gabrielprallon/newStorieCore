using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy;
namespace CharacterH
{
    public class CharacterHandler : MonoBehaviour
    {
        [SerializeField]
        private List<bool> m_CharOnScreen;
        [SerializeField]
        private List<GameObject> m_CharList;
        [SerializeField]
        private List<GameObject> m_CharPrefabs;
        [SerializeField]
        private List<GameObject> m_CharSlots;
        [SerializeField]
        private float m_LastChangeTime;
        [SerializeField]
        private float m_secsToNextChange = 10f;



        void Awake()
        {
            m_CharOnScreen.Add(Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.SVar.m_Jorrah);
            m_CharOnScreen.Add(Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.SVar.m_Minotaur);
        }
        private void Update()
        {
            m_CharOnScreen[0] = Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.SVar.m_Jorrah;
            m_CharOnScreen[1] = Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.SVar.m_Minotaur;
        }
        public void CharactersActivated()
        {
            for (int i = 0; i<m_CharOnScreen.Count; i++)
            {
                if(m_CharOnScreen[i] == true)
                {
                    m_CharList[i].SetActive(true);
                }
                else
                {
                    m_CharList[i].SetActive(false);
                }
            }
        }


        public void CharacterSpawn()
        {
            int x;
            for (int i=0; i < m_CharList.Count; i++)
            {
                do
                {
                    
                    x = Random.Range(0, m_CharSlots.Count - 1);
                    m_CharList[i].transform.parent = m_CharSlots[x].transform;
                }while (m_CharSlots[x].transform.childCount > 1);
                m_CharList[i].GetComponent<RectTransform>().localPosition = Vector3.zero;
                //m_CharList[i].SetActive(true);
            }
        }
        public void CharacterPlaceTimer()
        {
            m_LastChangeTime += Time.deltaTime;
            if (m_LastChangeTime >= m_secsToNextChange)
            {
                    m_LastChangeTime = 0f;
                    CharacterSpawn();
            }
        }
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