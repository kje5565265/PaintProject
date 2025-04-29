using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace PaintProject
{
    [CustomEditor(typeof(UITab))]
    public class UITabInspector : UnityEditor.Editor
    {
        private SerializedProperty IsSelected;
        private SerializedProperty Obj_Select_Enable;
        private SerializedProperty Obj_Select_Disable;

        private void OnEnable()
        {
            IsSelected = serializedObject.FindProperty("_isSelected");
            
            Obj_Select_Enable = serializedObject.FindProperty("Obj_Select_Enable");
            Obj_Select_Disable = serializedObject.FindProperty("Obj_Select_Disable");
        }

        public override void OnInspectorGUI()
        {
            OnDraw_IsActiveOn();
            
            GUILayout.Space(10);
            
            OnDraw_ActiveObjectList();
        }
        
        /// <summary>
        /// Open HoldemSelectRoom
        /// </summary>
        private void OnDraw_IsActiveOn()
        {
            {
                GUILayout.BeginHorizontal("PopupCurveSwatchBackground");
                GUILayout.Space(7);
                GUILayout.Label("IsActiveOn", "CN StatusWarn");
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();
            }
            
            serializedObject.Update();

            GUILayout.Label("상위 TabGroup에서 처음 한번 활성화되는 Tab", "CN StatusWarn");
            EditorGUILayout.PropertyField(IsSelected, new GUIContent("IsSelected"));

            serializedObject.ApplyModifiedProperties();
        }
        
        /// <summary>
        /// Open HoldemSelectRoom
        /// </summary>
        private void OnDraw_ActiveObjectList()
        {
            {
                GUILayout.BeginHorizontal("PopupCurveSwatchBackground");
                GUILayout.Space(7);
                GUILayout.Label("ActiveObjectList", "CN StatusWarn");
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();
            }
            
            serializedObject.Update();

            GUILayout.Label("IsActive 가 True 일때 Enable 되는 GameObject List.", "CN StatusWarn");
            EditorGUILayout.PropertyField(Obj_Select_Enable, new GUIContent("List Enable"), true);
            
            GUILayout.Space(5);
            
            GUILayout.Label("IsActive 가 False 일때 Disable 되는 GameObject List.", "CN StatusWarn");
            EditorGUILayout.PropertyField(Obj_Select_Disable, new GUIContent("List Disable"), true);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
