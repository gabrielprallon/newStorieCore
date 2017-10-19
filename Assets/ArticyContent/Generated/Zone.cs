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

namespace Articy.ProjectTheseus
{
    
    
    public class Zone : ArticyObject, IZone, IPropertyProvider, IObjectWithColor, IObjectWithDisplayName, IObjectWithLocalizableDisplayName, IObjectWithPreviewImage, IObjectWithText, IObjectWithLocalizableText, IObjectWithTransformation, IObjectWithVertices, IObjectWithExternalId, IObjectWithShortId, IObjectWithZIndex, IObjectWithSize
    {
        
        [SerializeField()]
        private String mLocaKey_DisplayName;
        
        [SerializeField()]
        private String mOverwritten_DisplayName;
        
        [SerializeField()]
        private PreviewImage mPreviewImage = new PreviewImage();
        
        [SerializeField()]
        private ArticyValueListVector2 mVertices = new ArticyValueListVector2();
        
        [SerializeField()]
        private Transformation mTransform = new Transformation();
        
        [SerializeField()]
        private ShapeType mShapeType = new ShapeType();
        
        [SerializeField()]
        private Color mColor;
        
        [SerializeField()]
        private String mLocaKey_Text;
        
        [SerializeField()]
        private String mOverwritten_Text;
        
        [SerializeField()]
        private String mExternalId;
        
        [SerializeField()]
        private Single mZIndex;
        
        [SerializeField()]
        private Vector2 mSize;
        
        [SerializeField()]
        private UInt32 mShortId;
        
        [SerializeField()]
        private VisibilityModes mVisibility = new VisibilityModes();
        
        [SerializeField()]
        private Color mOutlineColor;
        
        [SerializeField()]
        private Single mOutlineSize;
        
        [SerializeField()]
        private OutlineStyle mOutlineStyle = new OutlineStyle();
        
        [SerializeField()]
        private Boolean mShowDisplayName = new Boolean();
        
        [SerializeField()]
        private Color mDisplayNameColor;
        
        [SerializeField()]
        private Int32 mDisplayNameSize;
        
        [SerializeField()]
        private Boolean mDropShadow = new Boolean();
        
        [SerializeField()]
        private SelectabilityModes mSelectability = new SelectabilityModes();
        
        public String LocaKey_DisplayName
        {
            get
            {
                return mLocaKey_DisplayName;
            }
        }
        
        public String DisplayName
        {
            get
            {
                if ((mOverwritten_DisplayName != ""))
                {
                    return mOverwritten_DisplayName;
                }
                return Articy.Unity.ArticyDatabase.Localization.Localize(mLocaKey_DisplayName);
            }
            set
            {
                mOverwritten_DisplayName = value;
            }
        }
        
        public PreviewImage PreviewImage
        {
            get
            {
                return mPreviewImage;
            }
            set
            {
                mPreviewImage = value;
            }
        }
        
        public List<Vector2> Vertices
        {
            get
            {
                return mVertices.GetValue();
            }
            set
            {
                mVertices.SetValue(value);
            }
        }
        
        public Transformation Transform
        {
            get
            {
                return mTransform;
            }
            set
            {
                mTransform = value;
            }
        }
        
        public ShapeType ShapeType
        {
            get
            {
                return mShapeType;
            }
            set
            {
                mShapeType = value;
            }
        }
        
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
        
        public VisibilityModes Visibility
        {
            get
            {
                return mVisibility;
            }
            set
            {
                mVisibility = value;
            }
        }
        
        public Color OutlineColor
        {
            get
            {
                return mOutlineColor;
            }
            set
            {
                mOutlineColor = value;
            }
        }
        
        public Single OutlineSize
        {
            get
            {
                return mOutlineSize;
            }
            set
            {
                mOutlineSize = value;
            }
        }
        
        public OutlineStyle OutlineStyle
        {
            get
            {
                return mOutlineStyle;
            }
            set
            {
                mOutlineStyle = value;
            }
        }
        
        public Boolean ShowDisplayName
        {
            get
            {
                return mShowDisplayName;
            }
            set
            {
                mShowDisplayName = value;
            }
        }
        
        public Color DisplayNameColor
        {
            get
            {
                return mDisplayNameColor;
            }
            set
            {
                mDisplayNameColor = value;
            }
        }
        
        public Int32 DisplayNameSize
        {
            get
            {
                return mDisplayNameSize;
            }
            set
            {
                mDisplayNameSize = value;
            }
        }
        
        public Boolean DropShadow
        {
            get
            {
                return mDropShadow;
            }
            set
            {
                mDropShadow = value;
            }
        }
        
        public SelectabilityModes Selectability
        {
            get
            {
                return mSelectability;
            }
            set
            {
                mSelectability = value;
            }
        }
        
        protected override void CloneProperties(object aClone)
        {
            Zone newClone = ((Zone)(aClone));
            newClone.mLocaKey_DisplayName = mLocaKey_DisplayName;
            newClone.mOverwritten_DisplayName = mOverwritten_DisplayName;
            newClone.PreviewImage = PreviewImage;
            List<Vector2> temp_Vertices = new List<Vector2>();
            int i = 0;
            for (i = 0; (i < Vertices.Count); i = (i + 1))
            {
                temp_Vertices.Add(Vertices[i]);
            }
            newClone.Vertices = temp_Vertices;
            newClone.Transform = Transform;
            newClone.ShapeType = ShapeType;
            newClone.Color = Color;
            newClone.mLocaKey_Text = mLocaKey_Text;
            newClone.mOverwritten_Text = mOverwritten_Text;
            newClone.ExternalId = ExternalId;
            newClone.ZIndex = ZIndex;
            newClone.Size = Size;
            newClone.ShortId = ShortId;
            newClone.Visibility = Visibility;
            newClone.OutlineColor = OutlineColor;
            newClone.OutlineSize = OutlineSize;
            newClone.OutlineStyle = OutlineStyle;
            newClone.ShowDisplayName = ShowDisplayName;
            newClone.DisplayNameColor = DisplayNameColor;
            newClone.DisplayNameSize = DisplayNameSize;
            newClone.DropShadow = DropShadow;
            newClone.Selectability = Selectability;
            base.CloneProperties(newClone);
        }
        
        public override bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            if ((mOverwritten_DisplayName != ""))
            {
                return true;
            }
            if ((mOverwritten_Text != ""))
            {
                return true;
            }
            return base.IsLocalizedPropertyOverwritten(aProperty);
        }
        
        #region property provider interface
        public override void setProp(string aProperty, object aValue)
        {
            if ((aProperty == "DisplayName"))
            {
                DisplayName = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "PreviewImage"))
            {
                PreviewImage = ((PreviewImage)(aValue));
                return;
            }
            if ((aProperty == "Vertices"))
            {
                Vertices = ((List<Vector2>)(aValue));
                return;
            }
            if ((aProperty == "Transform"))
            {
                Transform = ((Transformation)(aValue));
                return;
            }
            if ((aProperty == "ShapeType"))
            {
                ShapeType = ((ShapeType)(aValue));
                return;
            }
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
            if ((aProperty == "Visibility"))
            {
                Visibility = ((VisibilityModes)(aValue));
                return;
            }
            if ((aProperty == "OutlineColor"))
            {
                OutlineColor = ((Color)(aValue));
                return;
            }
            if ((aProperty == "OutlineSize"))
            {
                OutlineSize = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "OutlineStyle"))
            {
                OutlineStyle = ((OutlineStyle)(aValue));
                return;
            }
            if ((aProperty == "ShowDisplayName"))
            {
                ShowDisplayName = System.Convert.ToBoolean(aValue);
                return;
            }
            if ((aProperty == "DisplayNameColor"))
            {
                DisplayNameColor = ((Color)(aValue));
                return;
            }
            if ((aProperty == "DisplayNameSize"))
            {
                DisplayNameSize = System.Convert.ToInt32(aValue);
                return;
            }
            if ((aProperty == "DropShadow"))
            {
                DropShadow = System.Convert.ToBoolean(aValue);
                return;
            }
            if ((aProperty == "Selectability"))
            {
                Selectability = ((SelectabilityModes)(aValue));
                return;
            }
            base.setProp(aProperty, aValue);
        }
        
        public override Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "DisplayName"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(DisplayName);
            }
            if ((aProperty == "PreviewImage"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(PreviewImage);
            }
            if ((aProperty == "Vertices"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Vertices);
            }
            if ((aProperty == "Transform"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Transform);
            }
            if ((aProperty == "ShapeType"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ShapeType);
            }
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
            if ((aProperty == "Visibility"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Visibility);
            }
            if ((aProperty == "OutlineColor"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(OutlineColor);
            }
            if ((aProperty == "OutlineSize"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(OutlineSize);
            }
            if ((aProperty == "OutlineStyle"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(OutlineStyle);
            }
            if ((aProperty == "ShowDisplayName"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ShowDisplayName);
            }
            if ((aProperty == "DisplayNameColor"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(DisplayNameColor);
            }
            if ((aProperty == "DisplayNameSize"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(DisplayNameSize);
            }
            if ((aProperty == "DropShadow"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(DropShadow);
            }
            if ((aProperty == "Selectability"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Selectability);
            }
            return base.getProp(aProperty);
        }
        #endregion
    }
}
