using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenario : MonoBehaviour {
    [SerializeField]
    private SlotManager m_SlotManager;

    public SlotManager SlotManager
    {
        get { return m_SlotManager; }
        set { m_SlotManager = value; }
    }

    public Transform GetRandomSlotTransform()
    {
        if (!m_SlotManager)
        {
            Debug.LogError("Scenario " + gameObject.name + " has no slot manager");
            return null;
        }
        return m_SlotManager.GetRandomSlotTransform();
    }
}
