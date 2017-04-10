using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Unity;
using Articy.Unity.Interfaces;
using Articy.ProjectTheseus;

public class DialogueHandler : MonoBehaviour, IArticyFlowPlayerCallbacks
{
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
            GetComponent<GameController>().GenerateStoryBlock(0, objWithText.Text);
            
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
            if (aBranches.Count > 0)
            GetComponent<ArticyFlowPlayer>().Play(aBranches[0]);

        foreach (var branch in aBranches)
        {
            // we only want branches that are valid
            if (!branch.IsValid) continue;
                
            // ... work with our valid branch
        }

        // Os botões precisam ter o Branch armazenados dentro deles.
    }

    // os botões podem chamar essa função para ir para a opção.
    public void GotToBranch(Branch target)
    {
        GetComponent<ArticyFlowPlayer>().Play(target);
    }
}
