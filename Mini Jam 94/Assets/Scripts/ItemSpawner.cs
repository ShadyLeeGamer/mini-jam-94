using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameManager gameManager;

    public Animator pipeAnimator;

    public GameObject ingrediantPrefab;
    public GameObject trashPrefab;
    public GameObject specialIngrediantPrefab;
    public GameObject specialTrashPrefab;

    private int rng;

    // Start is called before the first frame update
    void Start()
    {
        pipeAnimator.Play("PipeStart");
        StartCoroutine(randomNumberGenerator(rng));
    }

    public IEnumerator randomNumberGenerator(int rng)
    {
        while(true)
        {
            if (!gameManager.gameStarted)
            {
                yield return null;
                continue;
            }
            //rng to be number between 1 and 2. 1 is ingrediant, 2 is trash
            rng = Random.Range(0, 100);

            if (rng >= 0 && rng <= 50)
            {
                Instantiate(ingrediantPrefab, new Vector3(0, 10, 7), Quaternion.identity);
            }
            if(rng >= 51 && rng <= 89)
            {
                Instantiate(trashPrefab, new Vector3(0, 10, 7), Quaternion.identity);
            }
            if (rng >= 90 && rng <= 94)
            {
                Instantiate(specialIngrediantPrefab, new Vector3(0, 10, 7), Quaternion.identity);

            }
            if (rng >= 95 && rng <= 99)
            {
                Instantiate(specialTrashPrefab, new Vector3(0, 10, 7), Quaternion.identity);
            }
            pipeAnimator.Play("PipeFood");
            yield return new WaitForSeconds(2f);
        }
    }
}
