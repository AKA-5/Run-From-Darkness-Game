using UnityEngine;  

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "EndGame")
        {
            FindAnyObjectByType<GameManager>().EndGame(); // Game Over>
    }   }
}
