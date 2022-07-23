using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEngine;
using UnityEngine.UI;

public class colorPicker : MonoBehaviour
{
    [SerializeField] private Texture2D _texture;
    public static Color newColor;
    public Button[] selectColor;

    public void chanceColor(int index)
    {
        newColor = selectColor[index].image.color;
        Debug.Log(newColor);
    }
}
