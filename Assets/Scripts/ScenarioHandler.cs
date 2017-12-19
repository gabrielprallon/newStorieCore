using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Articy;


public class ScenarioHandler : MonoBehaviour {


    [SerializeField]
    private int m_lastScenario;
    [SerializeField]
    public List<GameObject> m_scenarioList;

	// Use this for initialization
	void Start () {
		
         // m_lastScenario = Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.SVar.m_Scenario;
            
        
	}
	
	// Update is called once per frame
	void Update () {
		/*if(m_lastScenario != Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.SVar.m_Scenario)
        {
            m_scenarioList[m_lastScenario].SetActive(false);
            m_scenarioList[Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.SVar.m_Scenario].SetActive(true);
            m_lastScenario = Articy.ProjectTheseus.GlobalVariables.ArticyGlobalVariables.Default.SVar.m_Scenario;
        }
        */
	}
}
