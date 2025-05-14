using UnityEngine;
using DG.Tweening;
public class TestAnim : MonoBehaviour
{
    [SerializeField] private GameObject obj;

    private void Start()
    {
        obj.transform.DOShakePosition(duration: 0.8f, strength: 0.25f, vibrato: 5).SetLoops(-1, LoopType.Yoyo);
    }
    private void Update()
    {
        
    }
}
