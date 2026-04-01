using UnityEngine;

public class Enemy : MonoBehaviour
{
    public BaseStats stats;
    private void Awake()
    {
        stats = new BaseStats(10, 10, 3, 1, 20);

    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void TakeDamage(Player player)
    {
        int newvida = stats.Health - player.Weapon.Damage;
        stats.SetHealth(newvida);
        Debug.Log ("daño sufrido" + newvida);
    }

    private void OnDestroy()
    {
        Debug.Log("oh no me destruyeron xD");
    }
}
 