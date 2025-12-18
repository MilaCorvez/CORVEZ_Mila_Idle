using UnityEngine;

public class GoldLink : MonoBehaviour
{

    public GoldManager gm;

    public void RiseGold()
    {
        gm.ChangeGold();
    }

}
