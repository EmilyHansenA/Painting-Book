using UnityEngine;
using UnityEngine.UI;

public class colorPicker : MonoBehaviour
{
    [SerializeField] private Button[] selectColor;

    internal static Color newColor;
    private void chanceColor(int index)
    {
        newColor = selectColor[index].image.color;
    }
}
