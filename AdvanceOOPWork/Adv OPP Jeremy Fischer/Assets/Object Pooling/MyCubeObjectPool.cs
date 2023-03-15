using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class MyCubeObjectPool : MonoBehaviour
{
    public int maxPoolSize = 20;
    public int stackDefaultCapicity = 20;
    public IObjectPool<MyCube> pool;

    public IObjectPool<MyCube> Pool
    {
        get 
        {  
            if(pool == null)
            {
                pool = new ObjectPool<MyCube>(CreatedPooledItem, OnTakeFromPool, OnReturnedToPool, OnDestroyPoolObject, true, maxPoolSize);
            }
            return pool;
        }
    }

    private MyCube CreatedPooledItem()
    {
        GameObject go = Instantiate(Resources.Load("Cube1", typeof(GameObject))) as GameObject;

        MyCube cube = go.AddComponent<MyCube>();
        go.name = "My Cube";

        cube.Pool = Pool;
        return cube;
    }

    private void OnTakeFromPool(MyCube cube)
    {
        cube.gameObject.SetActive(true);
    }

    private void OnDestroyPoolObject(MyCube cube)
    {
        Destroy(cube.gameObject);
    }

    private void OnReturnedToPool(MyCube cube)
    {
        cube.gameObject.SetActive(true);
    }

    public void Spawn()
    {
        int amount = Random.Range(1, 10);

        for(int i = 0; i < amount; i++)
        {
            var dino = Pool.Get();

            dino.transform.position = Random.insideUnitSphere*10;
        }
    }
}
