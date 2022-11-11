using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GateSettings : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _gateText;

    [SerializeField] private Image _topImage;
    [SerializeField] private Image _glassImage;

    [SerializeField] private Color _positiveColor;
    [SerializeField] private Color _negativeColor;

    [SerializeField] private GateDeformationType _deformationType;

    [SerializeField] private GameObject _expandLable;
    [SerializeField] private GameObject _shrinkLable;
    [SerializeField] private GameObject _upLable;
    [SerializeField] private GameObject _downLable;

    [SerializeField] private GameObject _imageTop;

    [SerializeField] private int _value;

    private List<Transform> _gateType;

    const float _alpha = 0.5f;



    private void OnValidate()
    {
        _gateType = _imageTop.GetComponents<Transform>().ToList();
        foreach (Transform s in _gateType)
        {
            s.gameObject.SetActive(false);
        }
        ChangeGate();
    }

    private void ChangeGate()
    {
        _gateText.text = _value.ToString();
        if (_value >= 0)
        {
            SetColor(_positiveColor);
        }
        else
        {
            SetColor(_negativeColor);
        }
    }

    private void SetColor(Color color)
    {
        _topImage.color = color;
        _glassImage.color = new Color(color.r, color.g, color.b, _alpha);
    }

}
