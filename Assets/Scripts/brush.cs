using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brush : MonoBehaviour
{
    [SerializeField] private int _textureSize = 128;
    [SerializeField] private TextureWrapMode _textureWrapMode;
    [SerializeField] private FilterMode _filterMode;
    [SerializeField] private Texture2D _texture;
    [SerializeField] private Material _material;

    [SerializeField] private Camera _camera;
    [SerializeField] private Collider _collider;
    [SerializeField] private Color _color;
    [SerializeField] private int _brushSize = 8;

    private void OnValidate()
    {
        if (_texture == null)
        {
            _texture = new Texture2D(_textureSize, _textureSize);
        }
        if (_texture.width != _textureSize)
        {
            _texture.Reinitialize(_textureSize, _textureSize);
        }
            _texture.wrapMode = _textureWrapMode;
            _texture.filterMode = _filterMode;
            _material.mainTexture = _texture;
            _texture.Apply();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0) && (toolsPicker._Brush == true))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (_collider.Raycast(ray, out hit, 100f))
            {
                int rayX = (int)(hit.textureCoord.x * _textureSize);
                int rayY = (int)(hit.textureCoord.y * _textureSize);

                for (int y = 0; y < _brushSize; y++)
                {
                    for (int x = 0; x < _brushSize; x++)
                    {
                        _texture.SetPixel(rayX + x, rayY + y, colorPicker.newColor);
                    }
                }
                _texture.Apply();
            }
        }
        if (Input.GetMouseButton(0) && (toolsPicker._Eraser == true))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (_collider.Raycast(ray, out hit, 100f))
            {
                int rayX = (int)(hit.textureCoord.x * _textureSize);
                int rayY = (int)(hit.textureCoord.y * _textureSize);

                for (int y = 0; y < _brushSize; y++)
                {
                    for (int x = 0; x < _brushSize; x++)
                    {
                        _texture.SetPixel(rayX + x, rayY + y, _color);
                    }
                }
                _texture.Apply();
            }
        }
    }
}
