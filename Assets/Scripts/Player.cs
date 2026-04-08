using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Player : BaseEntity
{
    public CircleCollider2D coll;
    public float range;

    public List<GameObject> Enemies = new();

    // public override
    public override void Awake()
    {
        //base.Awake();
        stats = new(10, 2, 10, 10, 10);
        coll = GetComponent<CircleCollider2D>();
        coll.radius = range;
    }
    public override void Start()
    {
        base.Start();
        InvokeRepeating("AutoAttackEnemies", 1f, 1f);
    }

    void Update()
    {

    }

    

    public void AutoAttackEnemies()
    {
        print("ATAQUE!");

        foreach (GameObject enemy in Enemies)
        {
            float distance = Vector3.Distance(enemy.transform.position, transform.position);

            if (distance <= range && enemy.GetComponent<Enemy>() != null)
            {
                enemy.GetComponent<Enemy>().TakeDamage(this, Elements.None);
                Debug.Log("eNEMIGO Dañado!!!!");
            }
                
        }

    }
    

    private void OnDestroy()
    {
        Debug.Log("oh no me cancelaron");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Enemy>() != null)
            Enemies.Add(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //if(Enemys.Find(collision.gameObject))
        Enemies.Remove(collision.gameObject);
    }

    public override void TakeDamage(BaseEntity damager, Elements element)
    {
        // base.TakeDamage(damager);

        Debug.Log(damager.Element);

        int damage = damager.Stats.Power;

        switch (damager.Element)
        {
            case Elements.None:
                //damage = damage;
                break;
            case Elements.Fire:
                damage *= 2;
                break;
            case Elements.Water:
                damage /= 2;
                break;
            case Elements.Earth:
                damage *= 3;
                break;
            case Elements.Air:
                damage = 0;
                break;
            default:
                break;
        }

        stats.TakeDamage(damage);
    }

}