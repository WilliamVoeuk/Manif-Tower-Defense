using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] int _playerBaseHP;
    public static int playerHP;
    [SerializeField] TextMeshProUGUI _playerHPText;

    [SerializeField] int _playerBaseCurrency;
    public int playerCurrency;
    [SerializeField] TextMeshProUGUI _playerCurrencyText;

    public static int roundsSurvived;
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
        roundsSurvived = 0;
    }
    private void Update()
    {
        _playerHPText.text = playerHP.ToString();
        _playerCurrencyText.text = playerCurrency.ToString();  
/*        if(playerHP <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }*/
    }

    public void HpLose(int Damage)
    {
        playerHP -= Damage;
    }

    public void GetMoney(int money)
    {
        playerCurrency += money;
    }
}
