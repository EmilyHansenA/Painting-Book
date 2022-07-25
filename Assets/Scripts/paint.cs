using UnityEngine;

public class paint : MonoBehaviour
{
    private SpriteRenderer _solid;
    private void Start()
    {
        _solid = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        fillObject();
        eraserObject();
    }
    private void fillObject()
    {
        if (toolsPicker.selectedTool == toolsPicker.fillName)
        {
            _solid.color = colorPicker.newColor;
        }
    }
    private void eraserObject()
    {
        if (toolsPicker.selectedTool == toolsPicker.eraserName)
        {
            _solid.color = Color.white;
        }
    }

}
