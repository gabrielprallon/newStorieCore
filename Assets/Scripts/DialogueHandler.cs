using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Articy.Unity;
using Articy.Unity.Interfaces;
using Articy.ProjectTheseus; // in case of project name change, change this
using UnityEngine.UI;

public class DialogueHandler : MonoBehaviour, IArticyFlowPlayerCallbacks
{
    private Branch m_lastNodePrinted = null;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void OnFlowPlayerPaused(IFlowObject aObject)
    {

        var objWithText = aObject as IObjectWithText;
        if (objWithText != null)
        {
            Debug.Log(objWithText.Text);// teste para ler o texto no console
                                        //Call the story block generator which spawn a story block on screen

            GameController gc = GetComponent<GameController>();
            if (gc)
            {
                if (gc.StoryNodesList.Count > 0 &&
                    gc.StoryNodesList[gc.StoryNodesList.Count - 1].GetComponent<Text>() &&
                    objWithText.Text == gc.StoryNodesList[gc.StoryNodesList.Count - 1].GetComponent<Text>().text)

                {
                    SceneManager.LoadScene("TheEnd");
                }
                else
                {
                    gc.GenerateStoryBlock(0, objWithText.Text);
                    
                }
            }
        }
    }
    public void OnBranchesUpdated(IList<Branch> aBranches)
    {
        // aBranches é a lista de opções que devem ser enviadas para os botões
        // aBranches[0].DefaultDescription : Acredito que esse é o texto que tem que ir no botão, mas tem que testar.

        // o loop a seguir pode ser utilizado caso os branchs condicionais estejam feitos corretamente no articy, como por exemplo a opção só aparecer se tiver ouro suficiente:
        if (aBranches.Count > 1)
            GetComponent<GameController>().SetButton(aBranches);
        else
            if (aBranches.Count > 0 && aBranches[0] != null && aBranches[0].IsValid)
        {
            if (aBranches[0].Target != GetComponent<ArticyFlowPlayer>().PausedOn)
            {
                m_lastNodePrinted = aBranches[0];
                GetComponent<ArticyFlowPlayer>().Play(aBranches[0]);
                Debug.Log("last node");
                Debug.Log(m_lastNodePrinted);
                Debug.Log(aBranches[0]);
                if (m_lastNodePrinted == null)
                {
                    Debug.Log("continua nulo");
                }

            }
            //if (m_lastNodePrinted != aBranches[0])
            else
            {
                SceneManager.LoadScene("TheEnd");
            }
        }
    }


    // os botões podem chamar essa função para ir para a opção.
    public void GotToBranch(Branch target)
    {
        if ((m_lastNodePrinted == null || (m_lastNodePrinted != null && m_lastNodePrinted != target)) && GetComponent<ArticyFlowPlayer>().AvailableBranches.Count >= 0){
            m_lastNodePrinted = target;
            GetComponent<ArticyFlowPlayer>().Play(target);
            Debug.Log(m_lastNodePrinted);
        }
    }

}
