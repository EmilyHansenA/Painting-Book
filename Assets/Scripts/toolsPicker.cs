using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class toolsPicker : MonoBehaviour
{
    public static bool _Eraser = false;
    public static bool _Brush = false;
    public static bool _Fill = false;

    public Button[] selectTool;

    private void Start()
    {
        _Eraser = false;
        _Brush = false;
        _Fill = false;
    }
    public void changeTools(string nameTools)
    {
        if (nameTools == "brush")
        {
            _Eraser = false;
            _Brush = true;
            _Fill = false;
        } else if (nameTools == "fill")
        {
            _Eraser = false;
            _Brush = false;
            _Fill = true;
        } else if (nameTools == "eraser")
        {
            _Eraser = true;
            _Brush = false;
            _Fill = false;
        }
    }
}
