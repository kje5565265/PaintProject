using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace PaintProject
{
    [CustomEditor(typeof(UITabGroup))]
    public class UITabGroupInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            {
                GUILayout.BeginHorizontal("PopupCurveSwatchBackground");
                GUILayout.Space(7);
                GUILayout.Label("Read Me", "CN StatusWarn");
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();
            }
            
            GUILayout.Label("하위에 있는 모든 UITab 컴퍼넌트를 하나의 Group 으로 관리합니다.", "CN StatusWarn");
            
            base.OnInspectorGUI();
        }
    }
}
