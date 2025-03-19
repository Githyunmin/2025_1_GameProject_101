using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int Health = 300;
    public float Timer = 1.0f;
    public int AttackPoint = 100;
    public float ScaleMultiplier = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;

        CharacterHealthUp();
        CheckDeath();
        UpdateObjectScale();

    }

    void CharacterHealthUp()
    {
        Timer -= Time.deltaTime;

        if (Timer <= 0)
        {
            Timer = 1.0f;
            Health += 20;
        }

    }

    public void CharactorHit(int Damage)
    {
       Health -= Damage;
    }

    void CheckDeath()
    {
        if (Health <= 0) 
            Destroy(gameObject);
    }

    void UpdateObjectScale()
    {
        float healthFactor = Mathf.Max(Health, 100);
        float scale = 1 + healthFactor * ScaleMultiplier;
        transform.localScale = new Vector3(scale, scale, scale);

    }
}
