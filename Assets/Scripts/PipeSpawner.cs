using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField] float timeToSpawn = 1f;
    [SerializeField] GameObject pipe1;
    [SerializeField] GameObject pipe2;
    [SerializeField] float height;

    private Coroutine spawnPipesCoroutine;
    private int pipeNum = 0;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            if(pipeNum == 0)
            {
                CreateAndMoves(pipe1);
          
            }
            else if(pipeNum == 1)
            {
                CreateAndMoves(pipe2);
             
            }
            yield return new WaitForSeconds(timeToSpawn);
            pipeNum = 1 - pipeNum; 
        }
    }

    private void CreateAndMoves(GameObject pipe)
    {
        GameObject newPipe = Instantiate(pipe);
        Vector3 randFactor = new Vector3(0, Random.Range(-height, height), 0);
        newPipe.transform.position = transform.position + randFactor;
        Destroy(newPipe, 5f); //5f - время до уничтожения обїекта - труби(5с)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
