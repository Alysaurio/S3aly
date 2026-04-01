using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private Player player;
    void Start()
    {
        InvokeRepeating("GenerateEnemy", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GenerateEnemy()
    {
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-4f, 4f);
        Vector2 enemypos = new Vector2(x, y);
        GameObject enemy = Instantiate(enemyPrefab);
        enemy.transform.position = enemypos;
    }

}
