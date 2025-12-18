using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.Universal;

public class GoldManager : MonoBehaviour
{
    public int goldAmount;
    public int power;
    public int Follower;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI Powertext;
    public TextMeshProUGUI Followertext;
    public GameObject Craigsprit;

    public Button buttonFive;
    public Button ButtonPower;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Craigsprit.SetActive(false);
        power = 1;
    }

    public void ChangeGold()
    {
        goldAmount += power;
    }

    public void AddPower(int powertoadd)
    {
        power += powertoadd;
    }
    public void RiseGold(int Goldtoadd)
    {
        goldAmount += Goldtoadd;
    }

    public void ChangeFollower()
    {
        if (goldAmount > 50)
        {
            goldAmount -= 50;

            Follower += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (goldAmount >= 100)
        {
            buttonFive.interactable = true;
        }
        else
        {
            buttonFive.interactable = false;
        }

        if (Follower >= 50)
        {
            ButtonPower.interactable = true;
        }
        else
        {
            ButtonPower.interactable = false;
        }

        goldText.text = goldAmount.ToString("00");
        Powertext.text = power.ToString("00");
        Followertext.text = Follower.ToString("00");
    }
}

