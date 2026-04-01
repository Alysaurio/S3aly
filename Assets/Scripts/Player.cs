using UnityEngine;

public class Player : MonoBehaviour
{
    private BaseStats stats;
    private WeaponData weapon;
    public float range;


    private void Awake()
    {
        stats = new BaseStats(100, 10, 5, 1, 20);
        weapon = new WeaponData(6, "gun");
    }
    void Start()
    {
        InvokeRepeating("AutoAttackEnemies", 1f, 1f);
    }

    void Update()
    {

    }

    

    public void AutoAttackEnemies()
    {
        print("ATAQUE!");

        GameObject[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in allEnemies)
        {
            float distance = Vector3.Distance(enemy.transform.position, transform.position);

            if (distance <= range)
                enemy.GetComponent<Enemy>().TakeDamage(this);
        }

    }
    public WeaponData Weapon => weapon;

    private void OnDestroy()
    {
        Debug.Log("oh no me cancelaron");
    }
}