using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Particle : MonoBehaviour
{
    private ParticleSystem particle;
    private SpriteRenderer sprite;
    private CircleCollider2D circleCollider;

    private void Awake()
    {
        particle = GetComponentInChildren<ParticleSystem>();
        sprite = GetComponent<SpriteRenderer>();
        circleCollider = GetComponent<CircleCollider2D>();
    }

    [System.Obsolete]
    private void Start()
    {
        particle.startColor = ColorSwitcher.instance.GetColor();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name.Equals("Duvar") || collision.collider.name.Equals("tuzak"))
        {
            Score.instance.CheckBestScore();
            StartCoroutine(Break());
        }
    }

    private IEnumerator Break()
    {
        SoundManagerScript.PlaySound();
        particle.Play();
        sprite.enabled = false;
        circleCollider.enabled = false;
      
        yield return new WaitForSeconds(particle.main.startLifetime.constantMax);
        
        Destroy(gameObject);
        PanelUIScipt.instance.SetActivePanel();
       
    }
}
