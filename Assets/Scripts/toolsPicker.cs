using UnityEngine;
using UnityEngine.UI;

public class toolsPicker : MonoBehaviour
{
    [SerializeField] private Button[] Tools;

    internal static string selectedTool;

    //Названия инструментов
    internal static string brushName = "brush";
    internal static string fillName = "fill";
    internal static string eraserName = "eraser";
    public void changeTools()
    {
        selectedTool = gameObject.tag.ToString();
    }
}
