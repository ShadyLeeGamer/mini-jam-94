using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashPointHitbox : MonoBehaviour
{

    ScoreManager scoreManager;


    private void Start()
    {
        scoreManager = GameObject.Find("scoreManager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trash")
        {
            scoreManager.increaseScore();
            FindObjectOfType<ParticleManager>().Play("Good", transform.position);
            Destroy(other.gameObject);
        }
        if (other.tag == "Ingrediant")
        {
            scoreManager.decreaseLives();
            FindObjectOfType<ParticleManager>().Play("Bad", transform.position);
            Destroy(other.gameObject);
        }
        if (other.tag == "SpecialTrash")
        {
            scoreManager.increaseLives();
            scoreManager.increaseScore();
            FindObjectOfType<ParticleManager>().Play("Good", transform.position);
            Destroy(other.gameObject);
        }
        if (other.tag == "SpecialIngrediant")
        {
            scoreManager.decreaseLives();
            FindObjectOfType<ParticleManager>().Play("Bad", transform.position);
            Destroy(other.gameObject);
        }
    } 
}
