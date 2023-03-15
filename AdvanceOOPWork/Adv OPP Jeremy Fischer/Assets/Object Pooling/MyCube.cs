using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class MyCube : MonoBehaviour
{
    private IObjectPool<MyCube> pool;
    public float currentHealth;

    [SerializeField] private float maxHealth = 100.0f;

    [SerializeField] private float timeToSelfRestruct = 3.0f;

    public IObjectPool<MyCube> Pool
    {
        get { return pool; }
        set { this.pool = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        this.currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnable()
    {
        StartCoroutine(SelfDestruct());
    }

    private void OnDisable()
    {
        ResetMyCube();
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(timeToSelfRestruct);
        TakeDamage(maxHealth);
    }

    private void ReturnToPool()
    {
        Pool.Release(this);
    }

    private void ResetMyCube()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        currentHealth = currentHealth - amount;

        if (currentHealth <= 0.0f)
        {
            ReturnToPool();
        }
    }
}
