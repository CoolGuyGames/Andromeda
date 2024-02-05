using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScript : MonoBehaviour
{
    private GameObject player;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        if(player.transform.position.x >= -10 && player.transform.position.x <= 10)
        {
            GetComponent<AudioSource>().pitch = (player.transform.position.x + 30) * 0.5f / 20f;
        }
        else
        {
            GetComponent<AudioSource>().pitch = Mathf.Sign(player.transform.position.x) == -1 ? 0.5f: 1;
        }
    }
}
