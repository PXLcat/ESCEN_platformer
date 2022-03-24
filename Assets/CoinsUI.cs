using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CoinsUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _coinsValue;

    private void OnEnable()
    {
        GameManager.Instance.OnCoinCollected += UpdateText;
        UpdateText();
    }

    private void UpdateText()
    {
        _coinsValue.text = GameManager.Instance.CoinsCollected.ToString();
    }

    private void OnDisable()
    {
        GameManager.Instance.OnCoinCollected -= UpdateText;
    }
}
