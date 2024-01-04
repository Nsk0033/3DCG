using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
	public GameObject player;

    // Update is called once per frame
    void Update()
    {
        // Ensure that the object only rotates around the y-axis
        Vector3 targetPosition = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);

        // Rotate towards the target position
        transform.LookAt(targetPosition);
    }
}
