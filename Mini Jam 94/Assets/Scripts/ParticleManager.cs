using System;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{

    public Particle[] particleEffects;

    public void Play(string name, Vector3 location)
    {
        Particle p = Array.Find(particleEffects, particle => particle.name == name);
        if (p == null)
        {
            Debug.Log("Particle Invalid");
            return;
        }
        GameObject particleInstantiate = Instantiate(p.particle, location, p.particle.transform.rotation);
        particleInstantiate.AddComponent<ParticleDestroyer>();
    }
}
