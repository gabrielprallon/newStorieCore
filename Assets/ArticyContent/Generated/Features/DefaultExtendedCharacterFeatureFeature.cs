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
    public class DefaultExtendedCharacterFeatureFeature : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private String mLocaKey_Motivation;
        
        [SerializeField()]
        private String mOverwritten_Motivation;
        
        [SerializeField()]
        private String mLocaKey_InnerConflict;
        
        [SerializeField()]
        private String mOverwritten_InnerConflict;
        
        [SerializeField()]
        private String mLocaKey_Skills;
        
        [SerializeField()]
        private String mOverwritten_Skills;
        
        [SerializeField()]
        private String mLocaKey_Fears;
        
        [SerializeField()]
        private String mOverwritten_Fears;
        
        [SerializeField()]
        private String mLocaKey_Habits;
        
        [SerializeField()]
        private String mOverwritten_Habits;
        
        [SerializeField()]
        private String mLocaKey_FurtherDetails;
        
        [SerializeField()]
        private String mOverwritten_FurtherDetails;
        
        public String LocaKey_Motivation
        {
            get
            {
                return mLocaKey_Motivation;
            }
        }
        
        public String Motivation
        {
            get
            {
                if ((mOverwritten_Motivation != ""))
                {
                    return mOverwritten_Motivation;
                }
                return Articy.Unity.ArticyDatabase.Localization.Localize(mLocaKey_Motivation);
            }
            set
            {
                mOverwritten_Motivation = value;
            }
        }
        
        public String LocaKey_InnerConflict
        {
            get
            {
                return mLocaKey_InnerConflict;
            }
        }
        
        public String InnerConflict
        {
            get
            {
                if ((mOverwritten_InnerConflict != ""))
                {
                    return mOverwritten_InnerConflict;
                }
                return Articy.Unity.ArticyDatabase.Localization.Localize(mLocaKey_InnerConflict);
            }
            set
            {
                mOverwritten_InnerConflict = value;
            }
        }
        
        public String LocaKey_Skills
        {
            get
            {
                return mLocaKey_Skills;
            }
        }
        
        public String Skills
        {
            get
            {
                if ((mOverwritten_Skills != ""))
                {
                    return mOverwritten_Skills;
                }
                return Articy.Unity.ArticyDatabase.Localization.Localize(mLocaKey_Skills);
            }
            set
            {
                mOverwritten_Skills = value;
            }
        }
        
        public String LocaKey_Fears
        {
            get
            {
                return mLocaKey_Fears;
            }
        }
        
        public String Fears
        {
            get
            {
                if ((mOverwritten_Fears != ""))
                {
                    return mOverwritten_Fears;
                }
                return Articy.Unity.ArticyDatabase.Localization.Localize(mLocaKey_Fears);
            }
            set
            {
                mOverwritten_Fears = value;
            }
        }
        
        public String LocaKey_Habits
        {
            get
            {
                return mLocaKey_Habits;
            }
        }
        
        public String Habits
        {
            get
            {
                if ((mOverwritten_Habits != ""))
                {
                    return mOverwritten_Habits;
                }
                return Articy.Unity.ArticyDatabase.Localization.Localize(mLocaKey_Habits);
            }
            set
            {
                mOverwritten_Habits = value;
            }
        }
        
        public String LocaKey_FurtherDetails
        {
            get
            {
                return mLocaKey_FurtherDetails;
            }
        }
        
        public String FurtherDetails
        {
            get
            {
                if ((mOverwritten_FurtherDetails != ""))
                {
                    return mOverwritten_FurtherDetails;
                }
                return Articy.Unity.ArticyDatabase.Localization.Localize(mLocaKey_FurtherDetails);
            }
            set
            {
                mOverwritten_FurtherDetails = value;
            }
        }
        
        private void CloneProperties(object aClone)
        {
            Articy.ProjectTheseus.Features.DefaultExtendedCharacterFeatureFeature newClone = ((Articy.ProjectTheseus.Features.DefaultExtendedCharacterFeatureFeature)(aClone));
            newClone.mLocaKey_Motivation = mLocaKey_Motivation;
            newClone.mOverwritten_Motivation = mOverwritten_Motivation;
            newClone.mLocaKey_InnerConflict = mLocaKey_InnerConflict;
            newClone.mOverwritten_InnerConflict = mOverwritten_InnerConflict;
            newClone.mLocaKey_Skills = mLocaKey_Skills;
            newClone.mOverwritten_Skills = mOverwritten_Skills;
            newClone.mLocaKey_Fears = mLocaKey_Fears;
            newClone.mOverwritten_Fears = mOverwritten_Fears;
            newClone.mLocaKey_Habits = mLocaKey_Habits;
            newClone.mOverwritten_Habits = mOverwritten_Habits;
            newClone.mLocaKey_FurtherDetails = mLocaKey_FurtherDetails;
            newClone.mOverwritten_FurtherDetails = mOverwritten_FurtherDetails;
        }
        
        public object CloneObject()
        {
            Articy.ProjectTheseus.Features.DefaultExtendedCharacterFeatureFeature clone = new Articy.ProjectTheseus.Features.DefaultExtendedCharacterFeatureFeature();
            CloneProperties(clone);
            return clone;
        }
        
        public virtual bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            if ((mOverwritten_Motivation != ""))
            {
                return true;
            }
            if ((mOverwritten_InnerConflict != ""))
            {
                return true;
            }
            if ((mOverwritten_Skills != ""))
            {
                return true;
            }
            if ((mOverwritten_Fears != ""))
            {
                return true;
            }
            if ((mOverwritten_Habits != ""))
            {
                return true;
            }
            if ((mOverwritten_FurtherDetails != ""))
            {
                return true;
            }
            return false;
        }
        
        #region property provider interface
        public void setProp(string aProperty, object aValue)
        {
            if ((aProperty == "Motivation"))
            {
                Motivation = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "InnerConflict"))
            {
                InnerConflict = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "Skills"))
            {
                Skills = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "Fears"))
            {
                Fears = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "Habits"))
            {
                Habits = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "FurtherDetails"))
            {
                FurtherDetails = System.Convert.ToString(aValue);
                return;
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "Motivation"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Motivation);
            }
            if ((aProperty == "InnerConflict"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(InnerConflict);
            }
            if ((aProperty == "Skills"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Skills);
            }
            if ((aProperty == "Fears"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Fears);
            }
            if ((aProperty == "Habits"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Habits);
            }
            if ((aProperty == "FurtherDetails"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(FurtherDetails);
            }
            return null;
        }
        #endregion
    }
}
