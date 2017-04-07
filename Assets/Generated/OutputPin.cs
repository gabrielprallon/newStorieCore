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
using System.Linq;

namespace Articy.ProjectTheseus
{
    
    
    [Serializable()]
    public class OutputPin : ArticyPrimitive, IOutputPin
    {
        
        [SerializeField()]
        private ArticyValueArticyScriptInstruction mText = new ArticyValueArticyScriptInstruction();
        
        [SerializeField()]
        private UInt64 mOwner;
        
        [SerializeField()]
        private ArticyValueListOutgoingConnection mConnections = new ArticyValueListOutgoingConnection();
        
        public ArticyScriptInstruction Text
        {
            get
            {
                return mText.GetValue();
            }
            set
            {
                mText.SetValue(value);
            }
        }
        
        public UInt64 Owner
        {
            get
            {
                return mOwner;
            }
            set
            {
                mOwner = value;
            }
        }
        
        public List<OutgoingConnection> Connections
        {
            get
            {
                return mConnections.GetValue();
            }
            set
            {
                mConnections.SetValue(value);
            }
        }
        
        public List<Articy.Unity.Interfaces.IOutgoingConnection> GetOutgoingConnections()
        {
            return Connections.Cast<IOutgoingConnection>().ToList();
        }
        
        public void Evaluate(Articy.Unity.IBaseScriptMethodProvider aMethodProvider, Articy.Unity.Interfaces.IGlobalVariables aGlobalVariables)
        {
            Text.CallScript(aMethodProvider, aGlobalVariables);
        }
        
        protected void CloneProperties(object aClone)
        {
            OutputPin newClone = ((OutputPin)(aClone));
            if ((Text != null))
            {
                newClone.Text = ((ArticyScriptInstruction)(Text.CloneObject()));
            }
            newClone.Owner = Owner;
            newClone.Connections = new List<OutgoingConnection>();
            int i = 0;
            for (i = 0; (i < Connections.Count); i = (i + 1))
            {
                newClone.Connections.Add(((OutgoingConnection)(Connections[i].CloneObject())));
            }
            newClone.Id = Id;
        }
        
        public override object CloneObject()
        {
            OutputPin clone = new OutputPin();
            CloneProperties(clone);
            return clone;
        }
        
        public override bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return base.IsLocalizedPropertyOverwritten(aProperty);
        }
    }
}
