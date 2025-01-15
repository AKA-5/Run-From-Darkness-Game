using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public Transform player;
    public Text distanceText;
    // Update is called once per frame
    void Update()
    {
        if (player.position.z <= 0)
        {
            distanceText.text = "0 m";   // will show whole number
        }
        else
        {
            distanceText.text = (player.position.z).ToString("0") + " m";
        }
    }
}
