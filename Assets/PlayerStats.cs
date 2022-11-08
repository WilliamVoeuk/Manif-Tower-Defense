using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] int _playerBaseHP;
    int playerHP;
    [SerializeField] TextMeshProUGUI _playerHPText;
    [SerializeField] int _playerBaseCurrency;
    int playerCurrency;
    [SerializeField] TextMeshProUGUI _playerCurrencyText;

    public static PlayerStats instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("already one PlayerStat");
        }
        instance = this;
    }
    private void Start()
    {
        playerHP = _playerBaseHP;
        playerCurrency = _playerBaseCurrency;
    }
    private void Update()
    {
        _playerHPText.text = playerHP.ToString();
        _playerCurrencyText.text = playerCurrency.ToString();  
    }

    public void HpLose(int Damage)
    {
        playerHP -= Damage;
    }

}
