using UnityEngine;
using UnityEngine.UI;

public class BulletDisplay : MonoBehaviour
{
    [SerializeField] Text bulletCounter = null;
    [SerializeField] KowalskiStateMachine kowalski = null;

    void Update()
    {
        bulletCounter.text = $"{kowalski.Bullets}/{kowalski.MaxBullets}";
    }
}