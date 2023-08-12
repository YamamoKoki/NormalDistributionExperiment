using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingPinScript : MonoBehaviour
{
    public GameObject pinPrefab; // ボウリングのピンのプレハブを指定
    public int rowCount;     // ピンを並べる行数
    public float rowSpacing; // 行間の距離
    public float pinSpacing; // ピン同士の間隔

    void Start()
    {
        SpawnPins();
    }

    void SpawnPins()
    {
        for (int row = 0; row < rowCount; row++)
        {
            int pinsInRow = row + 1;

            for (int i = 0; i < pinsInRow; i++)
            {
                float x = i * pinSpacing - row * pinSpacing * 0.5f;
                float z = row * rowSpacing;
                Vector3 spawnPosition = new Vector3(x, 0f, z);
                Instantiate(pinPrefab, spawnPosition, Quaternion.identity, transform);
            }
        }
    }
}
