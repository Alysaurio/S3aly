using UnityEngine;

public class BaseStats
{
    // Relación de Composición
    private int health;
    private int power;
    private int speed;
    private int knockback;
    private int xp;

    public BaseStats(int health, int power, int speed, int knockback, int xp)
    {
        this.health = health;
        this.power = power;
        this.speed = speed;
        this.knockback = knockback;
        this.xp = xp;
    }

    public void SetHealth(int health) => this.health = health;
    public void SetPower(int power) => this.power = power;
    public void SetSpeed(int speed) => this.speed = speed;
    public void SetKnockback(int knockback) => this.knockback = knockback;        
    public void SetXP(int xp) => this.xp = xp;  
    
    public int Health => health;
    public int Power => power;
    public int Speed => speed;
    public int Knockback => knockback;
    public int XP => xp;

    public void TakeDamage(int damage)
    {
        health-=damage;
        if (health < 0) 
            health = 0;
    }
    ~BaseStats()
    {
        Debug.Log("Eliminado por el garbage collector");
    }
}