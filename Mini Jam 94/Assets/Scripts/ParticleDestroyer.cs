using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroyer : MonoBehaviour
{
    ParticleSystem ps;

    float timer;

    private void Awake()
    {
        ps = gameObject.GetComponent<ParticleSystem>();

        timer = ps.main.duration;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            Destroy(gameObject);
        }
    }
}
