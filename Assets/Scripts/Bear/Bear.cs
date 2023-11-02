using UnityEngine;

public class Bear : MonoBehaviour
{
    private Transform playerTransform;

    void Start()
    {
        // Find the player GameObject by its tag and get its Transform component
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;
    }

    void Update()
    {
        // Compare the player's position to the bear's position
        if (playerTransform.position.x > transform.position.x)
        {
            // If the player is to the right of the bear, make the bear face right
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else if (playerTransform.position.x < transform.position.x)
        {
            // If the player is to the left of the bear, make the bear face left
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }
}
