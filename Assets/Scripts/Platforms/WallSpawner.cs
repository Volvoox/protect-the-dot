using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float maxTime = 0.8f;
    [SerializeField] private float timer = 0;
    [SerializeField] private float destroyTime;

    public GameObject reductionItem;

    public GameObject platform;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject platform4;
    public GameObject movingPlatform;
    public GameObject movingPlatform2;
    public GameObject tuzakPlatform;
    public GameObject mazePlatform;
    //public GameObject circlePlatform;
    [SerializeField] private float height;
 
    private int random;

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {

            GameObject newGameObject = Instantiate(platform);
            transform.position = new Vector2(transform.position.x, transform.position.y + 1.8f);
            newGameObject.transform.position = transform.position + new Vector3(Random.Range(-height, height), 0, 0);
            Destroy(newGameObject, destroyTime);

        }
    }

    // Update is called once per frame
    void Update()
    {
        RandomPlatformPicker();

    }
    void RandomPlatformPicker()
    {
        
        if (timer > maxTime)
        {
            maxTime = Random.Range(0.75f, 0.9f);
            random = Random.Range(1, 10);

            
            if(Score.instance.GetScore() % 12 == 0 && Score.instance.GetScore() >= 10)
            {
                SpawnerA(reductionItem, 0, 10f);
                
            }
            else
            {
                switch (random)
                {
                    case 1:
                        SpawnerA(platform, height, destroyTime);
                        break;
                    case 2:
                        if (Score.instance.GetScore() > 5)
                        {
                            SpawnerA(platform2, height, destroyTime);
                        }
                        break;
                    case 3:
                        if (Score.instance.GetScore() > 15)
                        {
                            SpawnerA(movingPlatform, 0, destroyTime);
                        }
                        break;
                    case 4:
                        if (Score.instance.GetScore() > 20)
                        {
                            SpawnerA(movingPlatform2, 0, destroyTime);
                        }
                        break;
                    case 5:
                        if (Score.instance.GetScore() > 25)
                        {
                            SpawnerA(tuzakPlatform, 0, destroyTime);
                        }
                        break;
                    case 6:
                        if (Score.instance.GetScore() > 30)
                        {
                            SpawnerA(platform3, 0, destroyTime);
                        }
                        break;

                    case 7:
                        if (Score.instance.GetScore() > 35)
                        {
                            SpawnerA(platform4, 0, destroyTime); // default destroyTime = 10f
                            maxTime = 3f;
                        }
                        break;
                    case 8:
                        if (Score.instance.GetScore() > 40)
                        {
                            SpawnerA(mazePlatform, 0, destroyTime);
                            maxTime = 3.2f;
                        }
                        break;
                    default:
                        SpawnerA(platform, height, destroyTime);
                        break;
                }
            }
            
            
            
        }
        timer += Time.deltaTime;
    }
  
    void SpawnerA(GameObject gameObject, float range, float destroyTime)
    {
        GameObject newGameObject = Instantiate(gameObject);
        newGameObject.transform.position = transform.position + new Vector3(Random.Range(-range, range), 0, 0);
        Destroy(newGameObject, destroyTime);
        timer = 0;
    }
}
