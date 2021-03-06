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
using Articy.ProjectTheseus;

namespace Articy.ProjectTheseus.Features
{
    
    
    [Serializable()]
    public class m_CharacterTemplateFeature : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private Single mm_CharID;
        
        [SerializeField()]
        private Single mm_CharHP;
        
        [SerializeField()]
        private Single mm_CharMP;
        
        [SerializeField()]
        private Boolean mm_CharOnScreen = new Boolean();
        
        [SerializeField()]
        private Boolean mm_CharIsDead = new Boolean();
        
        [SerializeField()]
        private ArticyValueArticyScriptCondition mm_CharScript = new ArticyValueArticyScriptCondition();
        
        [SerializeField()]
        private Single mm_CharMaxHP;
        
        [SerializeField()]
        private Single mm_CharMaxMP;
        
        public Single m_CharID
        {
            get
            {
                return mm_CharID;
            }
            set
            {
                mm_CharID = value;
            }
        }
        
        public Single m_CharHP
        {
            get
            {
                return mm_CharHP;
            }
            set
            {
                mm_CharHP = value;
            }
        }
        
        public Single m_CharMP
        {
            get
            {
                return mm_CharMP;
            }
            set
            {
                mm_CharMP = value;
            }
        }
        
        public Boolean m_CharOnScreen
        {
            get
            {
                return mm_CharOnScreen;
            }
            set
            {
                mm_CharOnScreen = value;
            }
        }
        
        public Boolean m_CharIsDead
        {
            get
            {
                return mm_CharIsDead;
            }
            set
            {
                mm_CharIsDead = value;
            }
        }
        
        public ArticyScriptCondition m_CharScript
        {
            get
            {
                return mm_CharScript.GetValue();
            }
            set
            {
                mm_CharScript.SetValue(value);
            }
        }
        
        public Single m_CharMaxHP
        {
            get
            {
                return mm_CharMaxHP;
            }
            set
            {
                mm_CharMaxHP = value;
            }
        }
        
        public Single m_CharMaxMP
        {
            get
            {
                return mm_CharMaxMP;
            }
            set
            {
                mm_CharMaxMP = value;
            }
        }
        
        private void CloneProperties(object aClone)
        {
            Articy.ProjectTheseus.Features.m_CharacterTemplateFeature newClone = ((Articy.ProjectTheseus.Features.m_CharacterTemplateFeature)(aClone));
            newClone.m_CharID = m_CharID;
            newClone.m_CharHP = m_CharHP;
            newClone.m_CharMP = m_CharMP;
            newClone.m_CharOnScreen = m_CharOnScreen;
            newClone.m_CharIsDead = m_CharIsDead;
            if ((m_CharScript != null))
            {
                newClone.m_CharScript = ((ArticyScriptCondition)(m_CharScript.CloneObject()));
            }
            newClone.m_CharMaxHP = m_CharMaxHP;
            newClone.m_CharMaxMP = m_CharMaxMP;
        }
        
        public object CloneObject()
        {
            Articy.ProjectTheseus.Features.m_CharacterTemplateFeature clone = new Articy.ProjectTheseus.Features.m_CharacterTemplateFeature();
            CloneProperties(clone);
            return clone;
        }
        
        public virtual bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return false;
        }
        
        #region property provider interface
        public void setProp(string aProperty, object aValue)
        {
            if ((aProperty == "m_CharID"))
            {
                m_CharID = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "m_CharHP"))
            {
                m_CharHP = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "m_CharMP"))
            {
                m_CharMP = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "m_CharOnScreen"))
            {
                m_CharOnScreen = System.Convert.ToBoolean(aValue);
                return;
            }
            if ((aProperty == "m_CharIsDead"))
            {
                m_CharIsDead = System.Convert.ToBoolean(aValue);
                return;
            }
            if ((aProperty == "m_CharScript"))
            {
                m_CharScript = ((ArticyScriptCondition)(aValue));
                return;
            }
            if ((aProperty == "m_CharMaxHP"))
            {
                m_CharMaxHP = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "m_CharMaxMP"))
            {
                m_CharMaxMP = System.Convert.ToSingle(aValue);
                return;
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "m_CharID"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(m_CharID);
            }
            if ((aProperty == "m_CharHP"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(m_CharHP);
            }
            if ((aProperty == "m_CharMP"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(m_CharMP);
            }
            if ((aProperty == "m_CharOnScreen"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(m_CharOnScreen);
            }
            if ((aProperty == "m_CharIsDead"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(m_CharIsDead);
            }
            if ((aProperty == "m_CharScript"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(m_CharScript);
            }
            if ((aProperty == "m_CharMaxHP"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(m_CharMaxHP);
            }
            if ((aProperty == "m_CharMaxMP"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(m_CharMaxMP);
            }
            return null;
        }
        #endregion
    }
}
