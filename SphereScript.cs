using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public GameObject prefabToSpawn; // プレファブとして生成するオブジェクトを指定
    public Transform spawnPoint1;   // 生成する位置1を指定
    public Transform spawnPoint2;   // 生成する位置2を指定
    public float spawnInterval = 2f; // 生成間隔（秒）
    public int maxprefab;
    public int prefabcount = 0;

    private bool isSpawningAtPoint1 = true; // 現在の生成位置フラグ

    private void Start()
    {
        // 指定された間隔で生成を開始
        InvokeRepeating("SpawnPrefabAtAlternateLocation", 0f, spawnInterval);
    }

    private void SpawnPrefabAtAlternateLocation()
    {
        // 生成位置を交互に切り替えて生成
        if (isSpawningAtPoint1)
        {
            if(prefabcount < maxprefab)
            {
                Instantiate(prefabToSpawn, spawnPoint1.position, Quaternion.identity);
                prefabcount++;
            }
        }
        else
        {
            if (prefabcount < maxprefab)
            {
                Instantiate(prefabToSpawn, spawnPoint2.position, Quaternion.identity);
                prefabcount++;
            }
        }

        // 生成位置フラグを切り替える
        isSpawningAtPoint1 = !isSpawningAtPoint1;
    }
}
