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
    
    
    public class Jump : ArticyObject, IJump, IPropertyProvider, IInputPinsOwner, IOutputPinsOwner, IObjectWithColor, IObjectWithText, IObjectWithLocalizableText, IObjectWithExternalId, IObjectWithShortId, IObjectWithPosition, IObjectWithZIndex, IObjectWithSize, IObjectWithTarget
    {
        
        [SerializeField()]
        private Color mColor;
        
        [SerializeField()]
        private String mLocaKey_Text;
        
        [SerializeField()]
        private String mOverwritten_Text;
        
        [SerializeField()]
        private String mExternalId;
        
        [SerializeField()]
        private Vector2 mPosition;
        
        [SerializeField()]
        private Single mZIndex;
        
        [SerializeField()]
        private Vector2 mSize;
        
        [SerializeField()]
        private UInt32 mShortId;
        
        [SerializeField()]
        private ArticyValueArticyObject mTarget = new ArticyValueArticyObject();
        
        [SerializeField()]
        private UInt64 mTargetPin;
        
        [SerializeField()]
        private ArticyValueListInputPin mInputPins = new ArticyValueListInputPin();
        
        [SerializeField()]
        private ArticyValueListOutputPin mOutputPins = new ArticyValueListOutputPin();
        
        public Color Color
        {
            get
            {
                return mColor;
            }
            set
            {
                mColor = value;
            }
        }
        
        public String LocaKey_Text
        {
            get
            {
                return mLocaKey_Text;
            }
        }
        
        public String Text
        {
            get
            {
                if ((mOverwritten_Text != ""))
                {
                    return mOverwritten_Text;
                }
                return Articy.Unity.ArticyDatabase.Localization.Localize(mLocaKey_Text);
            }
            set
            {
                mOverwritten_Text = value;
            }
        }
        
        public String ExternalId
        {
            get
            {
                return mExternalId;
            }
            set
            {
                mExternalId = value;
            }
        }
        
        public Vector2 Position
        {
            get
            {
                return mPosition;
            }
            set
            {
                mPosition = value;
            }
        }
        
        public Single ZIndex
        {
            get
            {
                return mZIndex;
            }
            set
            {
                mZIndex = value;
            }
        }
        
        public Vector2 Size
        {
            get
            {
                return mSize;
            }
            set
            {
                mSize = value;
            }
        }
        
        public UInt32 ShortId
        {
            get
            {
                return mShortId;
            }
            set
            {
                mShortId = value;
            }
        }
        
        public ArticyObject Target
        {
            get
            {
                return mTarget.GetValue();
            }
            set
            {
                mTarget.SetValue(value);
            }
        }
        
        public UInt64 TargetPin
        {
            get
            {
                return mTargetPin;
            }
            set
            {
                mTargetPin = value;
            }
        }
        
        public List<InputPin> InputPins
        {
            get
            {
                return mInputPins.GetValue();
            }
            set
            {
                mInputPins.SetValue(value);
            }
        }
        
        public List<OutputPin> OutputPins
        {
            get
            {
                return mOutputPins.GetValue();
            }
            set
            {
                mOutputPins.SetValue(value);
            }
        }
        
        public List<Articy.Unity.Interfaces.IInputPin> GetInputPins()
        {
            return InputPins.Cast<IInputPin>().ToList();
        }
        
        public List<Articy.Unity.Interfaces.IOutputPin> GetOutputPins()
        {
            return OutputPins.Cast<IOutputPin>().ToList();
        }
        
        protected override void CloneProperties(object aClone)
        {
            Jump newClone = ((Jump)(aClone));
            newClone.Color = Color;
            newClone.mLocaKey_Text = mLocaKey_Text;
            newClone.mOverwritten_Text = mOverwritten_Text;
            newClone.ExternalId = ExternalId;
            newClone.Position = Position;
            newClone.ZIndex = ZIndex;
            newClone.Size = Size;
            newClone.ShortId = ShortId;
            if ((mTarget != null))
            {
                newClone.mTarget = ((ArticyValueArticyObject)(mTarget.CloneObject()));
            }
            newClone.TargetPin = TargetPin;
            newClone.InputPins = new List<InputPin>();
            int i = 0;
            for (i = 0; (i < InputPins.Count); i = (i + 1))
            {
                newClone.InputPins.Add(((InputPin)(InputPins[i].CloneObject())));
            }
            newClone.OutputPins = new List<OutputPin>();
            for (i = 0; (i < OutputPins.Count); i = (i + 1))
            {
                newClone.OutputPins.Add(((OutputPin)(OutputPins[i].CloneObject())));
            }
            base.CloneProperties(newClone);
        }
        
        public override bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            if ((mOverwritten_Text != ""))
            {
                return true;
            }
            return base.IsLocalizedPropertyOverwritten(aProperty);
        }
        
        #region property provider interface
        public override void setProp(string aProperty, object aValue)
        {
            if ((aProperty == "Color"))
            {
                Color = ((Color)(aValue));
                return;
            }
            if ((aProperty == "Text"))
            {
                Text = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "ExternalId"))
            {
                ExternalId = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "Position"))
            {
                Position = ((Vector2)(aValue));
                return;
            }
            if ((aProperty == "ZIndex"))
            {
                ZIndex = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "Size"))
            {
                Size = ((Vector2)(aValue));
                return;
            }
            if ((aProperty == "ShortId"))
            {
                ShortId = ((UInt32)(aValue));
                return;
            }
            if ((aProperty == "Target"))
            {
                Target = ((ArticyObject)(aValue));
                return;
            }
            if ((aProperty == "TargetPin"))
            {
                TargetPin = ((UInt64)(aValue));
                return;
            }
            if ((aProperty == "InputPins"))
            {
                InputPins = ((List<InputPin>)(aValue));
                return;
            }
            if ((aProperty == "OutputPins"))
            {
                OutputPins = ((List<OutputPin>)(aValue));
                return;
            }
            base.setProp(aProperty, aValue);
        }
        
        public override Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "Color"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Color);
            }
            if ((aProperty == "Text"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Text);
            }
            if ((aProperty == "ExternalId"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ExternalId);
            }
            if ((aProperty == "Position"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Position);
            }
            if ((aProperty == "ZIndex"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ZIndex);
            }
            if ((aProperty == "Size"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Size);
            }
            if ((aProperty == "ShortId"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ShortId);
            }
            if ((aProperty == "Target"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Target);
            }
            if ((aProperty == "TargetPin"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(TargetPin);
            }
            if ((aProperty == "InputPins"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(InputPins);
            }
            if ((aProperty == "OutputPins"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(OutputPins);
            }
            return base.getProp(aProperty);
        }
        #endregion
    }
}
