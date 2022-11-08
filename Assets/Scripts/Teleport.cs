using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform TeleportSpot;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreControl.Score >= 400)
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(0, 2, 0), 20 * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            other.gameObject.transform.position = TeleportSpot.gameObject.transform.position;
        }
    }
}
