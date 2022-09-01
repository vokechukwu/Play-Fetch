using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool dogSpawnReady;
    
    private void Start()
    {
        dogSpawnReady = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if spacebar is pressed AND the bool dogSpawnReady equals false. Start the makedogs routine.
        if (Input.GetKeyDown(KeyCode.Space) && dogSpawnReady == false)
            StartCoroutine(makeDogs());
    }
    IEnumerator makeDogs()
    {
        //sets the bool to true so spacebar can't be pressed until this is done.
        dogSpawnReady = true;

        //Spawns the dog
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        //waits for 1 second
        yield return new WaitForSeconds(1);

        //sets the bool to false so that spacebar can once more be pressed
        dogSpawnReady = false;
    }
 
 }
