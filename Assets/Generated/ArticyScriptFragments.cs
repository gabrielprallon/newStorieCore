// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using Articy.Unity.Interfaces;
using Articy.Unity;

namespace Articy.ProjectTheseus.GlobalVariables
{
    
    
    [Articy.Unity.ArticyCodeGenerationHashAttribute(636335337204577343)]
    public class ArticyScriptFragments : BaseScriptFragments, ISerializationCallbackReceiver
    {
        
        #region Fields
        private System.Collections.Generic.Dictionary<int, System.Func<ArticyGlobalVariables, Articy.Unity.IBaseScriptMethodProvider, bool>> Conditions = new System.Collections.Generic.Dictionary<int, System.Func<ArticyGlobalVariables, Articy.Unity.IBaseScriptMethodProvider, bool>>();
        
        private System.Collections.Generic.Dictionary<int, System.Action<ArticyGlobalVariables, Articy.Unity.IBaseScriptMethodProvider>> Instructions = new System.Collections.Generic.Dictionary<int, System.Action<ArticyGlobalVariables, Articy.Unity.IBaseScriptMethodProvider>>();
        #endregion
        
        #region Script fragments
        /// <summary>
        /// ObjectID: 0x0
        /// Articy Object ref: articy://localhost/view/6e76f652-26e7-4e37-a606-62280680ae25/0?pane=selected&amp;tab=current
        /// </summary>
        public void Script_lsPX0fTn0KjGv0fD2YcFA(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            setProp(aGlobalVariablesState, aMethodProvider , getObj(aGlobalVariablesState, aMethodProvider, "m_Jorrah"), "SCProperties.m_HP",getProp(aGlobalVariablesState, aMethodProvider , getObj(aGlobalVariablesState, aMethodProvider, "m_Jorrah"), "SCProperties.m_HP") - 20);
            aGlobalVariablesState.SVar.m_Jorrah = true;
            print(aGlobalVariablesState, aMethodProvider, getProp(aGlobalVariablesState, aMethodProvider , getObj(aGlobalVariablesState, aMethodProvider, "m_Jorrah"), "SCProperties.m_HP"));
        }
        
        /// <summary>
        /// ObjectID: 0x0
        /// Articy Object ref: articy://localhost/view/6e76f652-26e7-4e37-a606-62280680ae25/0?pane=selected&amp;tab=current
        /// </summary>
        public void Script_ER5nMu6Y6E6BW8dFPLwskw(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.SVar.m_Gold += 200;
            print(aGlobalVariablesState, aMethodProvider, aGlobalVariablesState.SVar.m_Gold);
            print(aGlobalVariablesState, aMethodProvider, "gold");
        }
        
        /// <summary>
        /// ObjectID: 0x0
        /// Articy Object ref: articy://localhost/view/6e76f652-26e7-4e37-a606-62280680ae25/0?pane=selected&amp;tab=current
        /// </summary>
        public void Script_cCYSLz2wPk6zTDlcloQ25A(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.SVar.m_Minotaur = false;
        }
        
        /// <summary>
        /// ObjectID: 0x0
        /// Articy Object ref: articy://localhost/view/6e76f652-26e7-4e37-a606-62280680ae25/0?pane=selected&amp;tab=current
        /// </summary>
        public void Script_WXTV43C0kkilTp0xtMANgQ(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.SVar.m_Jorrah = false;
        }
        
        /// <summary>
        /// ObjectID: 0x0
        /// Articy Object ref: articy://localhost/view/6e76f652-26e7-4e37-a606-62280680ae25/0?pane=selected&amp;tab=current
        /// </summary>
        public void Script_Y0fIaERrMk2IpH8sz8AWHQ(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.SVar.m_Gold += 500;
            print(aGlobalVariablesState, aMethodProvider, aGlobalVariablesState.SVar.m_Gold);
        }
        
        /// <summary>
        /// ObjectID: 0x0
        /// Articy Object ref: articy://localhost/view/6e76f652-26e7-4e37-a606-62280680ae25/0?pane=selected&amp;tab=current
        /// </summary>
        public void Script_ir50VPq2Pkm96NXu2ZGqWA(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.SVar.m_Gold += 500;
            print(aGlobalVariablesState, aMethodProvider, aGlobalVariablesState.SVar.m_Gold);
        }
        
        /// <summary>
        /// ObjectID: 0x0
        /// Articy Object ref: articy://localhost/view/6e76f652-26e7-4e37-a606-62280680ae25/0?pane=selected&amp;tab=current
        /// </summary>
        public void Script_45TQBxsq80u5zdsURbs9A(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            print(aGlobalVariablesState, aMethodProvider, aGlobalVariablesState.SVar.m_Gold);
        }
        
        /// <summary>
        /// ObjectID: 0x0
        /// Articy Object ref: articy://localhost/view/6e76f652-26e7-4e37-a606-62280680ae25/0?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_gVjgA7il0mvaMrVCPSC9w(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return (getProp(aGlobalVariablesState, aMethodProvider , getObj(aGlobalVariablesState, aMethodProvider, "m_Jorrah"), "SCProperties.m_HP")>0)&&(getProp(aGlobalVariablesState, aMethodProvider , getObj(aGlobalVariablesState, aMethodProvider, "m_Jorrah"),"SCProperties.m_MP")>0);
        }
        
        /// <summary>
        /// ObjectID: 0x0
        /// Articy Object ref: articy://localhost/view/6e76f652-26e7-4e37-a606-62280680ae25/0?pane=selected&amp;tab=current
        /// </summary>
        public void Script_iT1evNtkOkOSfruX8iDHhQ(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            print(aGlobalVariablesState, aMethodProvider, getProp(aGlobalVariablesState, aMethodProvider , getObj(aGlobalVariablesState, aMethodProvider, "m_Jorrah"), "SCProperties.m_HP"));
        }
        
        /// <summary>
        /// ObjectID: 0x0
        /// Articy Object ref: articy://localhost/view/6e76f652-26e7-4e37-a606-62280680ae25/0?pane=selected&amp;tab=current
        /// </summary>
        public void Script_G0YZsgN1n06ybCHDjDY1vA(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            print(aGlobalVariablesState, aMethodProvider, getProp(aGlobalVariablesState, aMethodProvider , getObj(aGlobalVariablesState, aMethodProvider, "m_Jorrah"), "SCProperties.m_HP"));
        }
        
        /// <summary>
        /// ObjectID: 0x0
        /// Articy Object ref: articy://localhost/view/6e76f652-26e7-4e37-a606-62280680ae25/0?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_epVCcly54USxkBpAg5bBFg(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.SVar.m_Gold <= 700;
        }
        
        /// <summary>
        /// ObjectID: 0x0
        /// Articy Object ref: articy://localhost/view/6e76f652-26e7-4e37-a606-62280680ae25/0?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_BjSOH2I1iki52oOcYIWQA(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.SVar.m_Gold >= 1000;
        }
        #endregion
        
        #region Unity serialization
        public void OnBeforeSerialize()
        {
        }
        
        public void OnAfterDeserialize()
        {
            Conditions = new System.Collections.Generic.Dictionary<int, System.Func<ArticyGlobalVariables, Articy.Unity.IBaseScriptMethodProvider, bool>>();
            Instructions = new System.Collections.Generic.Dictionary<int, System.Action<ArticyGlobalVariables, Articy.Unity.IBaseScriptMethodProvider>>();
            Instructions.Add(-1887393292, this.Script_lsPX0fTn0KjGv0fD2YcFA);
            Instructions.Add(-959215097, this.Script_ER5nMu6Y6E6BW8dFPLwskw);
            Instructions.Add(-291799849, this.Script_cCYSLz2wPk6zTDlcloQ25A);
            Instructions.Add(-1985282182, this.Script_WXTV43C0kkilTp0xtMANgQ);
            Instructions.Add(1690822263, this.Script_Y0fIaERrMk2IpH8sz8AWHQ);
            Instructions.Add(-1426452181, this.Script_ir50VPq2Pkm96NXu2ZGqWA);
            Instructions.Add(-1322069855, this.Script_45TQBxsq80u5zdsURbs9A);
            Conditions.Add(-1841985237, this.Script_gVjgA7il0mvaMrVCPSC9w);
            Instructions.Add(-1917802865, this.Script_iT1evNtkOkOSfruX8iDHhQ);
            Instructions.Add(-1590465484, this.Script_G0YZsgN1n06ybCHDjDY1vA);
            Conditions.Add(517214222, this.Script_epVCcly54USxkBpAg5bBFg);
            Conditions.Add(-578862994, this.Script_BjSOH2I1iki52oOcYIWQA);
        }
        #endregion
        
        #region Script execution
        public override void CallInstruction(Articy.Unity.Interfaces.IGlobalVariables aGlobalVariables, int aHash, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            if ((Instructions.ContainsKey(aHash) == false))
            {
                return;
            }
            if ((aMethodProvider != null))
            {
                aMethodProvider.IsCalledInForecast = aGlobalVariables.IsInShadowState;
            }
            Instructions[aHash].Invoke(((ArticyGlobalVariables)(aGlobalVariables)), aMethodProvider);
        }
        
        public override bool CallCondition(Articy.Unity.Interfaces.IGlobalVariables aGlobalVariables, int aHash, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            if ((Conditions.ContainsKey(aHash) == false))
            {
                return true;
            }
            if ((aMethodProvider != null))
            {
                aMethodProvider.IsCalledInForecast = aGlobalVariables.IsInShadowState;
            }
            return Conditions[aHash].Invoke(((ArticyGlobalVariables)(aGlobalVariables)), aMethodProvider);
        }
        #endregion
    }
}
