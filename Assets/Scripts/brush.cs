using UnityEngine;

public class brush : MonoBehaviour
{
    [SerializeField] private TextureWrapMode _textureWrapMode;
    [SerializeField] private FilterMode _filterMode;
    [SerializeField] private Texture2D _texture;
    [SerializeField] private Material _material;

    [SerializeField] private Camera _camera;
    [SerializeField] private Collider _collider;

    [SerializeField] private int brushSize = 8;
    [SerializeField] private int textureSize = 128;
    private void Update()
    {
        if (Input.GetMouseButton(0) && (toolsPicker.selectedTool == toolsPicker.brushName))
        {
            Painting(colorPicker.newColor);
        }
        if (Input.GetMouseButton(0) && (toolsPicker.selectedTool == toolsPicker.fillName))
        {
            Painting(colorPicker.newColor);
        }
        if (Input.GetMouseButton(0) && (toolsPicker.selectedTool == toolsPicker.eraserName))
        {
            Painting(Color.white);
        }
    }
    private void OnValidate()
    {
        if (_texture == null)
        {
            _texture = new Texture2D(textureSize, textureSize);
        }
        if (_texture.width != textureSize)
        {
            _texture.Reinitialize(textureSize, textureSize);
        }
            _texture.wrapMode = _textureWrapMode;
            _texture.filterMode = _filterMode;
            _material.mainTexture = _texture;
            _texture.Apply();
    }
    private void Painting(Color selectedColor)
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (_collider.Raycast(ray, out hit, 100f))
        {
            int rayX = (int)(hit.textureCoord.x * textureSize);
            int rayY = (int)(hit.textureCoord.y * textureSize);

            for (int y = 0; y < brushSize; y++)
            {
                for (int x = 0; x < brushSize; x++)
                {
                    _texture.SetPixel(rayX + x, rayY + y, selectedColor);
                }
            }
            _texture.Apply();
        }
    }
}
