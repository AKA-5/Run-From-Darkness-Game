using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 3, -10);

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = player.position + offset;
    }
}
