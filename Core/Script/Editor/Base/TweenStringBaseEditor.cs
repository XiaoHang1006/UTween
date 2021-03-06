﻿/////////////////////////////////////////////////////////////////////////////
//
//  Script   : TweenStringBaseEditor.cs
//  Info     : TweenStringBase 编辑器
//  Author   : ls9512 2021
//  E-mail   : ls9512@vip.qq.com
//
/////////////////////////////////////////////////////////////////////////////
#if UNITY_EDITOR
using UnityEditor;

namespace Aya.Tween
{
    public abstract class TweenStringBaseEditor : TweenerTVCEditor
    {
        public new Tweener<string> Tweener => Target as Tweener<string>;

        public override void DoDrawValue()
        {
            base.DoDrawValue();
            // EditorGUILayout.BeginHorizontal();
            var fromProperty = TweenParamProperty.FindProperty(TweenKey.FromStr);
            fromProperty.stringValue = EditorGUILayout.TextField("From", fromProperty.stringValue);
            var toProperty = TweenParamProperty.FindProperty(TweenKey.ToStr);
            toProperty.stringValue = EditorGUILayout.TextField("To", toProperty.stringValue);
            // EditorGUILayout.EndHorizontal();
        }

        public override bool DoDrawCallback()
        {
            base.DoDrawCallback();
            if (!IsCallbackOpen) return false;

            var onValueProperty = TweenParamProperty.FindProperty(TweenKey.OnValueString);
            EditorGUILayout.PropertyField(onValueProperty);
            return true;
        }
    }
}
#endif