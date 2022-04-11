using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _icon;
    [SerializeField] private bool _isBuyed = false;
    [SerializeField] protected Bullet _bullet;
    [SerializeField] private float _setСooldownValue;
    
    public string Label => _label;
    
    public int Price => _price;
    
    public Sprite Icon => _icon;
    
    public bool IsBuyed => _isBuyed;
    
    public float СooldownTimer { get; private set; }

    public abstract void Shoot(Transform shootPoint);

    public void Buy()
    {
        _isBuyed = true;
    }

    public void DecrementCooldownTime()
    {
        СooldownTimer -= Time.deltaTime;
    }

    public void ResetCooldownTime()
    {
        СooldownTimer = _setСooldownValue;
    }
}
