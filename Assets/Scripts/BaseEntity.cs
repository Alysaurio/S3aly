using UnityEngine;

public enum Elements
{
    None,
    Fire,
    Water,
    Earth,
    Air,
}

public abstract class BaseEntity : MonoBehaviour
{
    [SerializeField] protected int entityID;
    [SerializeField] protected string entityName;
    [SerializeField] protected string entityDescription;

    [SerializeField] protected Elements element;

    [SerializeField] protected BaseStats stats;

    public virtual void Awake()
    {
       
    }
    public virtual void Start()
    {
        
    }

   public virtual void TakeDamage(BaseEntity damager , Elements element)
    {
        stats.TakeDamage(damager.stats.Power);
    }

    public BaseStats Stats => stats;
    public Elements Element => element;

}
