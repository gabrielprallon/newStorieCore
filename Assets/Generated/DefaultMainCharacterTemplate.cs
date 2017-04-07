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
    
    
    public class DefaultMainCharacterTemplate : Entity, IEntity, IPropertyProvider, IObjectWithFeatureDefaultExtendedCharacterFeature, IObjectWithFeatureDefaultBasicCharacterFeature
    {
        
        [SerializeField()]
        private ArticyValueDefaultMainCharacterTemplateTemplate mTemplate = new ArticyValueDefaultMainCharacterTemplateTemplate();
        
        private static Articy.ProjectTheseus.Templates.DefaultMainCharacterTemplateTemplateConstraint mConstraints = new Articy.ProjectTheseus.Templates.DefaultMainCharacterTemplateTemplateConstraint();
        
        public Articy.ProjectTheseus.Templates.DefaultMainCharacterTemplateTemplate Template
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
        
        public static Articy.ProjectTheseus.Templates.DefaultMainCharacterTemplateTemplateConstraint Constraints
        {
            get
            {
                return mConstraints;
            }
        }
        
        public DefaultExtendedCharacterFeatureFeature GetFeatureDefaultExtendedCharacterFeature()
        {
            return Template.DefaultExtendedCharacterFeature;
        }
        
        public DefaultBasicCharacterFeatureFeature GetFeatureDefaultBasicCharacterFeature()
        {
            return Template.DefaultBasicCharacterFeature;
        }
        
        protected override void CloneProperties(object aClone)
        {
            DefaultMainCharacterTemplate newClone = ((DefaultMainCharacterTemplate)(aClone));
            if ((Template != null))
            {
                newClone.Template = ((Articy.ProjectTheseus.Templates.DefaultMainCharacterTemplateTemplate)(Template.CloneObject()));
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