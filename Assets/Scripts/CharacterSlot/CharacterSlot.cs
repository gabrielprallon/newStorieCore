using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSlot : MonoBehaviour {

    // Use this for initialization

    private SlotManager m_Manager;

    private void Awake()
    {
        if (!m_Manager)
            m_Manager = GetComponentInParent<SlotManager>();
        if (!m_Manager)
        {
            Debug.LogError("No slot manager for slot " + gameObject.name);
        }
        else
        {
            m_Manager.RegisterSlot(this);
        }
        
    }
}
