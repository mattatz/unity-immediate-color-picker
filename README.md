unity-immediate-color-picker
=================

Color picker for Unity in immediate GUI mode.

![Demo](https://raw.githubusercontent.com/mattatz/unity-immediate-color-picker/master/Captures/Demo.gif)

## Usage

in a MonoBehaviour,

```cs

IMColorPicker colorPicker;

void OnGUI()
{
    if(colorPicker == null)
    {
        colorPicker = new IMColorPicker();
    }
    colorPicker.DrawWindow(); // draw color picker UI with GUI.Window
    colorPicker.DrawColorPicker(); // or draw color picker UI only
}

```

You can use color presets with IMColorPreset(ScriptableObject).

```cs

public IMColorPreset preset;
IMColorPicker colorPicker;

void OnGUI()
{
    if(colorPicker == null)
    {
        colorPicker = new IMColorPicker(preset);
    }
    // ...
}

```

See example scenes for details.
