﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Unity;
using Articy.ProjectTheseus;

namespace LifeBarHandler
{
    public class HpMpHandler : MonoBehaviour
    {
        [SerializeField]
        private string m_CharName = "";
        [SerializeField]
        private GameObject m_HPBarMask;
        private RectTransform m_HPBarMaskRT;
        [SerializeField]
        private GameObject m_MPBarMask;
        private RectTransform m_MPBarMaskRT;
        private Entity m_Char;
        [SerializeField]
        private float m_MaxHP = 100f;
        [SerializeField]
        private float m_MaxMP = 100f;
        [SerializeField]
        private float m_HPdif;
        [SerializeField]
        private float m_MPdif;
        private bool m_CharLoaded = false;
        private float m_MaxWidth;

        // Use this for initialization
        void Start()
        {
            Invoke("LoadCharacters", 0.01f);
            m_HPBarMaskRT = m_HPBarMask.GetComponent<RectTransform>();
            m_MPBarMaskRT = m_MPBarMask.GetComponent<RectTransform>();
            m_MaxWidth = m_HPBarMaskRT.sizeDelta.x;
            //a_Jorrah.getProp("m_HP");
            //m_CharName.;


        }
        //load the character infos from articy
        void LoadCharacters()
        {
            m_Char = ArticyDatabase.GetObject<Entity>(m_CharName);
            m_CharLoaded = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (m_CharLoaded)
            {
                HpBarWid();
                MpBarWid();
            }
        }
        // controls wid of the hp bars based on the percentage of current health
        public void HpBarWid()
        {
            m_HPdif = m_Char.getProp("m_CharacterTemplate.m_CharHP") / m_Char.getProp("m_CharacterTemplate.m_CharMaxHP");
                //.SCProperties.m_HP/m_MaxHP;
            if (m_HPdif != 0)
            {
                m_HPBarMaskRT.sizeDelta = new Vector2(m_MaxWidth * m_HPdif, m_HPBarMaskRT.sizeDelta.y);
            }
        }
        // controls the wid of the mp bar based on the percentage of current magic power
        public void MpBarWid()
        {
            m_MPdif = m_Char.getProp("m_CharacterTemplate.m_CharMP") / m_Char.getProp("m_CharacterTemplate.m_CharMaxMP");
            //m_MPdif = m_Char.Template.SCProperties.m_MP / m_MaxMP;
            if (m_MPdif != 0)
            {
                m_MPBarMaskRT.sizeDelta = new Vector2(m_MaxWidth * m_MPdif, m_MPBarMaskRT.sizeDelta.y);
            }
        }

       
    }
}
