using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class paint : MonoBehaviour
{
    public SpriteRenderer solid;

    private void OnMouseDown()
    {
        Fill();
        Eraser();
    }

    public void Fill()
    {
        if (toolsPicker._Fill == true)
        {
            solid.color = colorPicker.newColor;
        }
    }
    public void Eraser()
    {
        if (toolsPicker._Eraser == true)
        {
            solid.color = Color.clear;
        }
    }
}
