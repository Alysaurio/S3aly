using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class WeaponData
{
    private int damage;
    private string weaponname;
    public WeaponData(int damage, string weaponname)
    {
        this.damage = damage;
        this.weaponname = weaponname;
    }

    public void SetDamage(int damage) => this.damage = damage;
    public int Damage => damage;
}
