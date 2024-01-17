using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour

{
    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;
    [Header("platform Object")]
    public GameObject platform;
    public GameObject FakePlatform;
    float pos = 0;
    float FakePos = 0;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {
            SpawnPlatforms();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpawnPlatforms()
    {
        Instantiate(platform, new Vector3(Random.value * 10 - 5f, pos, 0.5f), Quaternion.identity);
        pos += 4f;
        Instantiate(FakePlatform, new Vector3(Random.value * 10 - 5f, pos, 0.5f), Quaternion.identity);
        FakePos += 4f;

    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
    }
}
