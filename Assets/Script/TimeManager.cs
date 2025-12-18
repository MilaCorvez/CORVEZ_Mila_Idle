using System.Collections;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float timeToWait;
    public GoldManager goldeneye;
    public int x;
    public bool shouldXtournerenboucletellaroue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(FaireDesTrucs());
    }

    public float tempsEcoule;
    // Update is called once per frame
    void Update()
    {
    }
    private float tempsDAttente;
    public bool pause;

    public void TooglePause()
    {
        pause = !pause;
    }

    public IEnumerator FaireDesTrucs()
    {
        while (true)
        {
            while (pause)
            {
                yield return new WaitForEndOfFrame();
            }
            goldeneye.ChangeFollower();
            yield return new WaitForSeconds(0.5f);
        }
    }

}
