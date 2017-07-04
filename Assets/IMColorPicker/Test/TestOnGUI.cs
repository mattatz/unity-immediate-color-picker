using UnityEngine;
using System.Collections;

using imColorPicker;

namespace imColorPickerTest
{

    public class TestOnGUI : MonoBehaviour {

        [SerializeField] IMColorPreset preset;
        [SerializeField] Color color;

        IMColorPicker colorPicker;
        [SerializeField] bool window;

        void OnGUI()
        {
            if(colorPicker == null)
            {
                colorPicker = new IMColorPicker(preset);
            }

            using(new GUILayout.HorizontalScope())
            {
                window = GUILayout.Toggle(window, "Window");
            }

            if(window)
            {
                colorPicker.DrawWindow();
            } else
            {
                using(new GUILayout.HorizontalScope())
                {
                    GUILayout.Space(10f);
                    using(new GUILayout.VerticalScope())
                    {
                        GUILayout.Space(10f);
                        GUILayout.Label("IMColorPicker");
                        colorPicker.DrawColorPicker();
                    }
                }
            }

            color = colorPicker.color;
        } 

    }

}


