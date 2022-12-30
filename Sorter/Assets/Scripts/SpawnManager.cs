using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] int numberOfSpheres;
    [SerializeField] GameObject[] spheresPrefabs;

    private float spawnHeight = 17;
    private float spawnX = 2.1f;
    private float spawnZMin = 22.8f;
    private float spawnZMax = 27.2f;
    // Start is called before the first frame update
    void Start()
    {
        numberOfSpheres = Random.Range(10, 50);
        StartCoroutine(SpawnSingleSphere());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void SpawnSpheres()
    //{
    //    for (int i = 0; i < numberOfSpheres; i++)
    //    {
    //        StartCoroutine(SpawnSingleSphere());
    //    }
    //}

    IEnumerator SpawnSingleSphere()
    {
        for (int i = 0; i < numberOfSpheres; i++)
        {
            int sphereIndex = Random.Range(0, spheresPrefabs.Length);

            Instantiate(spheresPrefabs[sphereIndex], GetSpawnCoordinates(), spheresPrefabs[0].transform.rotation);
            yield return new WaitForSeconds(0.75f);
        }
    }

    Vector3 GetSpawnCoordinates()
    {
        return new Vector3(Random.Range(-spawnX, spawnX), spawnHeight, Random.Range(spawnZMin, spawnZMax));
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
