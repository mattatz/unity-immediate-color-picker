using UnityEngine;
using UnityEditor;

using System.Collections;

namespace imColorPicker
{

    public class IMColorPickerEditor {

        [MenuItem("Assets/Create/IMColorPreset")]
        public static void CreateAsset()
        {
            CreateAsset<IMColorPreset>();
        }

        static void CreateAsset<Type>() where Type : ScriptableObject
        {
            Type item = ScriptableObject.CreateInstance<Type>();

            string path = AssetDatabase.GenerateUniqueAssetPath("Assets/IMColorPicker/" + typeof(Type) + ".asset");

            AssetDatabase.CreateAsset(item, path);
            AssetDatabase.SaveAssets();

            EditorUtility.FocusProjectWindow();
            Selection.activeObject = item;
        }

    }

}


