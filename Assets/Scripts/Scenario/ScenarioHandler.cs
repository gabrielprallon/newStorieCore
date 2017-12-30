using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Articy;


public class ScenarioHandler : MonoBehaviour {


    [SerializeField]
    private int m_lastScenario;
    [SerializeField]
    public List<Scenario> m_scenarioList;

    private static ScenarioHandler m_Instance;

    public static ScenarioHandler Instance
    {
        get
        {
            if(!m_Instance)
            {
                Debug.LogError("No ScenarioHanlder in the scene, adding new");
                GameObject go = new GameObject();
                m_Instance = go.AddComponent<ScenarioHandler>();
            }
            return m_Instance;
        }
    }

    public Scenario CurrentScenario
    {
        get
        {
            return m_scenarioList[m_lastScenario];
        }
    }

    public Transform GetRandomSlotTransform()
    {
        return CurrentScenario.GetRandomSlotTransform();
    }

    private void Awake()
    {
        m_Instance = this;
    }

    // Use this for initialization
    void Start () {

        m_lastScenario = Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.m_ArticyGlobalVariables.m_Scenario;
        m_scenarioList[m_lastScenario].gameObject.SetActive(false);
        m_scenarioList[Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.m_ArticyGlobalVariables.m_Scenario].gameObject.SetActive(true);
        m_lastScenario = Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.m_ArticyGlobalVariables.m_Scenario;


    }
	
	// Update is called once per frame
	void Update () {
        if(m_lastScenario != Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.m_ArticyGlobalVariables.m_Scenario)
        {
            m_scenarioList[m_lastScenario].gameObject.SetActive(false);
            m_scenarioList[Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.m_ArticyGlobalVariables.m_Scenario].gameObject.SetActive(true);
            m_lastScenario = Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.m_ArticyGlobalVariables.m_Scenario;
            CharacterH.CharacterHandler.Instance.CharacterSpawn();
        }
    }
}
