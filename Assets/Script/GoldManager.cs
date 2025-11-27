using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldManager : MonoBehaviour
{
    public int goldAmount;
    public int power;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI Powertext;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 1;
    }

    public void ChangeGold()
    {
        goldAmount += power;
    }

    public void ChangePower()
    {
        if (goldAmount > 10)
        {
            goldAmount -= 10;

            power += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        goldText.text = goldAmount.ToString("00");
    }
}

