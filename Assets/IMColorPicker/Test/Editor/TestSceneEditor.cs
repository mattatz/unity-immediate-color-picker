using UnityEngine;
using UnityEditor;

using System.Collections;

using imColorPicker;

namespace imColorPickerTest
{

    [CustomEditor (typeof(TestScene))]
    public class TestSceneEditor : Editor {

        IMColorPicker colorPicker;
        IMColorPreset preset;

        void OnSceneGUI()
        {
            int controlId = GUIUtility.GetControlID(FocusType.Passive);

            if (colorPicker == null)
            {
                preset = Resources.Load<IMColorPreset>("imPreset");
                colorPicker = new IMColorPicker(preset);
            }

            using(new GUILayout.AreaScope(new Rect(20, 20, 200, 200)))
            {
                Handles.BeginGUI();
                colorPicker.DrawColorPicker();
                Handles.EndGUI();
            }

            if (Event.current.type == EventType.Layout)
            {
                HandleUtility.AddDefaultControl(controlId);
            }
        }

        void OnDisable()
        {
            var path = AssetDatabase.GetAssetPath(preset);
            var origin = AssetDatabase.LoadAssetAtPath(path, typeof(IMColorPreset));
            EditorUtility.CopySerialized(preset, origin);
            AssetDatabase.SaveAssets();
        }

    }

}


