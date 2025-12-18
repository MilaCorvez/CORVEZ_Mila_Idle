using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.Universal;
using System.Collections.Generic;

public class GoldManager : MonoBehaviour
{
    public int goldAmount;
    public int power;
    public int Follower;

    public TextMeshProUGUI goldText;
    public TextMeshProUGUI Powertext;
    public TextMeshProUGUI Followertext;

    public Button buttonFive;
    public Button buttonFour;
    public Button buttonSix;
    public Button buttonSevent;
    public Button ButtonPower;

    public int powerUpOneLevel;
    public List<GameObject> powerUpOneSprites;

    public int powerUpTwoLevel;
    public List<GameObject> powerUpTwoSprites;

    public int followerUpThreeLevel;
    public List<GameObject> followersUpThreeSprites;

    public int followerUpFourLevel;
    public List<GameObject> followersUpFourSprites;


    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void ChangeGold()
    {
        goldAmount += power;
    }

    public void AddPowerUpOne()
    {
        goldAmount -= 100;
        powerUpOneSprites[powerUpOneLevel].SetActive(true);
        powerUpOneLevel += 1;
        AddPower(2);
    }
    public void AddPowerUpTwo()
    {
        goldAmount -= 500;
        powerUpTwoSprites[powerUpTwoLevel].SetActive(true);
        powerUpTwoLevel += 1;
        AddPower(5);
    }
    public void AddFollowersUpThree()
    {
        Follower -= 100;
        followersUpThreeSprites[followerUpThreeLevel].SetActive(true);
        followerUpThreeLevel += 1;
        AddPower(10);
    }
    public void AddFollowersUpFour()
    {
        Follower -= 500;
        followersUpFourSprites[followerUpFourLevel].SetActive(true);
        followerUpFourLevel += 1;
        AddPower(15);
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

        if (Follower >= 500 && followerUpFourLevel < 4)
        {
            buttonSevent.interactable = true;
        }
        else
        {
            buttonSevent.interactable = false;
        }

        if (Follower >= 100 && followerUpThreeLevel < 4)
        {
            buttonSix.interactable = true;
        }
        else
        {
            buttonSix.interactable = false;
        }

        if (goldAmount >= 500 && powerUpTwoLevel < 4)
        {
            buttonFour.interactable = true;
        }
        else
        {
            buttonFour.interactable = false;
        }

        if (goldAmount >= 100 && powerUpOneLevel < 4)
        {
            buttonFive.interactable = true;
        }
        else
        {
            buttonFive.interactable = false;
        }

        if (goldAmount >= 50)
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

