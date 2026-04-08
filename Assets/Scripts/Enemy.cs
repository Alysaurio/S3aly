using UnityEngine;

public class Enemy : BaseEntity
{
    GameObject target;
    public override void Awake()
    {
        //base.Awake();
        stats = new(20, 2, 10, 10, 10);

        target = GameObject.FindGameObjectWithTag("Player");
    }
  
    void Update()
    {
        
    }
    /*public void TakeDamage(Player player)
    {
        int newvida = stats.Health - player.Weapon.Damage;
        stats.SetHealth(newvida);
        Debug.Log ("daño sufrido" + newvida);
    }*/

    public override void TakeDamage(BaseEntity damager, Elements element)
    {
        if (stats == null || damager == null || damager.Stats == null)
        {
            Debug.Log("fatal error");
            return;
        }
        int newvida = stats.Health - damager.Stats.Power ;
        stats.SetHealth(newvida);
        Debug.Log("daño sufrido" + newvida);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
            TakeDamage(,);
    }

    private void OnDestroy()
    {
        Debug.Log("oh no me destruyeron xD");
    }
}
 