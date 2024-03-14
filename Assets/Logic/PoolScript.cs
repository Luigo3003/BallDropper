using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolScript : MonoBehaviour
{
    public static PoolScript PSInstance;

    private List<GameObject> availableObjectpoolList;
    private List<GameObject> activepoolList;

    [SerializeField] private GameObject PoolPrefab;
    [SerializeField] private Transform[] SpawnPoints;
    [SerializeField] public int StartingNumberofObjects;


    private void Awake()
    {
        if (PSInstance == null)
        {
            PSInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        availableObjectpoolList = new List<GameObject>();
        activepoolList = new List<GameObject>();
    }
    void Start()
    {
        CreateObject(StartingNumberofObjects);
    }

    private void CreateObject(int numberOfObjects)
    {
        GameObject TempObject;
        for (int i = 0; i < numberOfObjects; i++)
        {
            int randomSpawn = Random.Range(0, SpawnPoints.Length);
            TempObject = Instantiate(PoolPrefab, SpawnPoints[randomSpawn].position, Quaternion.identity,transform);
            TempObject.SetActive(true);
            availableObjectpoolList.Add(TempObject);
        }
    }

    public GameObject RequestObject()
    {
        if (availableObjectpoolList.Count != 0)
        {
            GameObject requestedObject = availableObjectpoolList[0];
            availableObjectpoolList.RemoveAt(0);
            activepoolList.Add(requestedObject);
            requestedObject.SetActive(true);
            return requestedObject;
        }

        else
        {
            return null; 
        }
    }

    public void TurnOffObjects(GameObject objectToDespawn)
    {
        objectToDespawn.SetActive(false);
        availableObjectpoolList.Add(objectToDespawn);
        activepoolList.Remove(objectToDespawn);
    }

    public Transform GetRandomSpawnPoint()
    {
        int randomSpawn = Random.Range(0, SpawnPoints.Length);
        return SpawnPoints[randomSpawn].transform;
    }

    public void TurnOnObjects()
    {
        for (int i = 0; i < StartingNumberofObjects; i++)
        {
            GameObject GOToActivate = availableObjectpoolList[i].gameObject;
            Transform RandomSpawn = GetRandomSpawnPoint();
            GOToActivate.transform.position = RandomSpawn.position;
            GOToActivate.SetActive(true);
            activepoolList.Add(GOToActivate);
        }
    }
}
