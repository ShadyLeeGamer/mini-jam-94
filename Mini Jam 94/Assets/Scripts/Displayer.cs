using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Displayer : MonoBehaviour
{
    PhysicMaterial physicMaterial;
    public GameObject[] itemArray;


    // Gets a random object from the array and turns the object into it
    private void Awake()
    {
        GameObject randomObject = itemArray[Random.Range(0, itemArray.Length)];

        gameObject.GetComponent<MeshFilter>().mesh = randomObject.GetComponent<MeshFilter>().sharedMesh;
        gameObject.GetComponent<MeshRenderer>().material = randomObject.GetComponent<MeshRenderer>().sharedMaterial;

        // Adds a mesh collider to the object with the physics material
        SphereCollider mCollider = gameObject.AddComponent<SphereCollider>();
        mCollider.material = physicMaterial = new PhysicMaterial();
    }

    private void Start()
    {

        //get name of mesh on gameobject
        MeshFilter meshFilter = gameObject.GetComponent<MeshFilter>();
        var currentMesh = meshFilter.sharedMesh;

        if(gameObject.CompareTag("Ingrediant"))
        {
            if (currentMesh.name == "Flour")
            {
                physicMaterial.bounciness = 0;
                physicMaterial.staticFriction = 0.4f;
            }
            if (currentMesh.name == "Egg")
            {
                physicMaterial.bounciness = 0.7f;
                physicMaterial.staticFriction = 0;
            }
            if (currentMesh.name == "Cupcake")
            {
                physicMaterial.bounciness = 0.6f;
                physicMaterial.staticFriction = 0.2f;
            }
            if (currentMesh.name == "Croissant")
            {
                physicMaterial.bounciness = 0.6f;
                physicMaterial.staticFriction = 0.2f;
            }
            if (currentMesh.name == "Cheesecake")
            {
                physicMaterial.bounciness = 0.1f;
                physicMaterial.staticFriction = 0.3f;
            }
            if (currentMesh.name == "Banana")
            {
                physicMaterial.bounciness = 0.5f;
                physicMaterial.staticFriction = 0.3f;
            }

        }

        if (gameObject.CompareTag("Trash"))
        {
            if (currentMesh.name == "BananaPeel")
            {
                Debug.Log("bp");
                physicMaterial.bounciness = 0.5f;
                physicMaterial.staticFriction = 0.2f;
            }
            if (currentMesh.name == "BrokenPlate")
            {
                Debug.Log("plate");
                physicMaterial.bounciness = 0;
                physicMaterial.staticFriction = 0.3f;
            }
            if (currentMesh.name == "CrumpledPaper")
            {
                physicMaterial.bounciness = 0.9f;
                physicMaterial.staticFriction = 0;
            }
            if (currentMesh.name == "MoldyBread")
            {
                physicMaterial.bounciness = 0.4f;
                physicMaterial.staticFriction = 0.4f;
            }
        }

    }
}
