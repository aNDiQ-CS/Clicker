using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusButtonAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private int lifeTime;

    private void Start()
    {
        lifeTime = BonusButtonSpawner.GetLifeTime();
        StartCoroutine(ButtonLife());
    }

    private void PopUp()
    {
        _animator.SetTrigger("Created");
    }

    private void FadeAway()
    {
        _animator.SetTrigger("Destroyed");
    }

    private IEnumerator ButtonLife()
    {
        PopUp();
        yield return new WaitForSeconds(lifeTime - 1);
        FadeAway();
    }
}
