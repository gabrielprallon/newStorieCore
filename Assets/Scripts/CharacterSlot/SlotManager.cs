using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour {

    private List<CharacterSlot> m_Slots = new List<CharacterSlot>();

    private void Awake()
    {
        Scenario scenario = GetComponentInParent<Scenario>();
        if (scenario)
        {
            scenario.SlotManager = this;
        }
        else
        {
            Debug.LogError("No scenario for slot manager: " + gameObject.name);
        }
    }

    public void RegisterSlot(CharacterSlot slot)
    {
        if (!m_Slots.Contains(slot))
            m_Slots.Add(slot);
    }

    public Transform GetRandomSlotTransform()
    {
        return (m_Slots[Random.Range(0, m_Slots.Count)].transform);
    }
}
