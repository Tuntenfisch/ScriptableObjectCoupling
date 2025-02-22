﻿using Tuntenfisch.ScriptableObjectCoupling.Common.Editor;
using UnityEditor;
using UnityEngine;

namespace Tuntenfisch.ScriptableObjectCoupling.Events.Editor
{
    [CustomEditor(typeof(GameEvent))]
    public class EventEditor : ScritpableObjectCouplingEditor
    {
        #region Private Fields
        private SerializedProperty m_onGameEventInvokedProperty;
        #endregion

        #region Protected Methods
        protected override void DisplayInspectorVariables()
        {
            EditorGUI.BeginDisabledGroup(!Application.isPlaying);
            GameEvent gameEvent = target as GameEvent;

            if (GUILayout.Button(ObjectNames.NicifyVariableName(nameof(gameEvent.InvokeGameEvent))))
            {
                gameEvent.InvokeGameEvent();
            }
            EditorGUI.EndDisabledGroup();
        }
        #endregion
    }
}