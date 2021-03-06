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
using Articy.Unity;
using Articy.Unity.Interfaces;
using Articy.ProjectTheseus.Features;

namespace Articy.ProjectTheseus
{
    
    
    public class p_Character : Entity, IEntity, IPropertyProvider, IObjectWithFeatureSCProperties, IObjectWithFeatureDefaultBasicCharacterFeature
    {
        
        [SerializeField()]
        private ArticyValuep_CharacterTemplate mTemplate = new ArticyValuep_CharacterTemplate();
        
        private static Articy.ProjectTheseus.Templates.p_CharacterTemplateConstraint mConstraints = new Articy.ProjectTheseus.Templates.p_CharacterTemplateConstraint();
        
        public Articy.ProjectTheseus.Templates.p_CharacterTemplate Template
        {
            get
            {
                return mTemplate.GetValue();
            }
            set
            {
                mTemplate.SetValue(value);
            }
        }
        
        public static Articy.ProjectTheseus.Templates.p_CharacterTemplateConstraint Constraints
        {
            get
            {
                return mConstraints;
            }
        }
        
        public SCPropertiesFeature GetFeatureSCProperties()
        {
            return Template.SCProperties;
        }
        
        public DefaultBasicCharacterFeatureFeature GetFeatureDefaultBasicCharacterFeature()
        {
            return Template.DefaultBasicCharacterFeature;
        }
        
        protected override void CloneProperties(object aClone)
        {
            p_Character newClone = ((p_Character)(aClone));
            if ((Template != null))
            {
                newClone.Template = ((Articy.ProjectTheseus.Templates.p_CharacterTemplate)(Template.CloneObject()));
            }
            base.CloneProperties(newClone);
        }
        
        public override bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return base.IsLocalizedPropertyOverwritten(aProperty);
        }
        
        #region property provider interface
        public override void setProp(string aProperty, object aValue)
        {
            if (aProperty.Contains("."))
            {
                Template.setProp(aProperty, aValue);
                return;
            }
            base.setProp(aProperty, aValue);
        }
        
        public override Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if (aProperty.Contains("."))
            {
                return Template.getProp(aProperty);
            }
            return base.getProp(aProperty);
        }
        #endregion
    }
}
