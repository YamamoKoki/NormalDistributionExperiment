using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public GameObject prefabToSpawn; // �v���t�@�u�Ƃ��Đ�������I�u�W�F�N�g���w��
    public Transform spawnPoint1;   // ��������ʒu1���w��
    public Transform spawnPoint2;   // ��������ʒu2���w��
    public float spawnInterval = 2f; // �����Ԋu�i�b�j
    public int maxprefab;
    public int prefabcount = 0;

    private bool isSpawningAtPoint1 = true; // ���݂̐����ʒu�t���O

    private void Start()
    {
        // �w�肳�ꂽ�Ԋu�Ő������J�n
        InvokeRepeating("SpawnPrefabAtAlternateLocation", 0f, spawnInterval);
    }

    private void SpawnPrefabAtAlternateLocation()
    {
        // �����ʒu�����݂ɐ؂�ւ��Đ���
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

        // �����ʒu�t���O��؂�ւ���
        isSpawningAtPoint1 = !isSpawningAtPoint1;
    }
}
