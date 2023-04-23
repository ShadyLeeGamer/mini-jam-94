using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingrediantPointHitbox : MonoBehaviour
{

    ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GameObject.Find("scoreManager").GetComponent<ScoreManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ingrediant")
        {
            scoreManager.increaseScore();
            FindObjectOfType<ParticleManager>().Play("Good", transform.position);
            Destroy(other.gameObject);
        }
        if (other.tag == "Trash")
        {
            scoreManager.decreaseLives();
            FindObjectOfType<ParticleManager>().Play("Bad", transform.position);
            Destroy(other.gameObject);
        }
        if (other.tag == "SpecialIngrediant")
        {
            scoreManager.increaseLives();
            scoreManager.increaseScore();
            FindObjectOfType<ParticleManager>().Play("Good", transform.position);
            Destroy(other.gameObject);
        }
        if (other.tag == "SpecialTrash")
        {
            scoreManager.decreaseLives();
            FindObjectOfType<ParticleManager>().Play("Bad", transform.position);
            Destroy(other.gameObject);
        }
    }

}
