using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Unity;
using Articy.Unity.Interfaces;

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
            Debug.Log(objWithText.Text); // teste para ler o texto no console
            // Alguma coisa aqui tem que receber o texto de "objWithText.Text" isso pode ser o texto tanto de um flow como de um dialog fragment
            // na real aqui tem que chamar a função que spawna storynodes/storyblocks (nao lembro o nome)
        }
    }

    public void OnBranchesUpdated(IList<Branch> aBranches)
    {
        // aBranches é a lista de opções que devem ser enviadas para os botões
        // aBranches[0].DefaultDescription : Acredito que esse é o texto que tem que ir no botão, mas tem que testar.

        // o loop a seguir pode ser utilizado caso os branchs condicionais estejam feitos corretamente no articy, como por exemplo a opção só aparecer se tiver ouro suficiente:

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
