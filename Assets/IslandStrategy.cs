using UnityEngine;

public class IslandStrategy : MonoBehaviour
{
    private IStrategyIsland StrategyIsland;
    [SerializeField] bool IsIslandMoveUpDn;
    [SerializeField] bool IsIslandShakeInvisIsland;
    [SerializeField] bool IsIslandMoveLR;
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;
    void SetStrategyIsland(IStrategyIsland NewStrategyIsland)
    {

        StrategyIsland = NewStrategyIsland;
        if (StrategyIsland != null)
        {
            StrategyIsland.Confirm(gameObject);
        }
    }
    private void Start()
    {
        if (IsIslandMoveUpDn)
        {
            SetStrategyIsland(new IslandMoveUpDn(new Vector3(x,y,z)));
        }
        if (IsIslandShakeInvisIsland)
        {
            SetStrategyIsland(new ShakeInvisIsland());
        }
        if (IsIslandMoveLR)
        {
            SetStrategyIsland(new IslandMoveLR(new Vector3(x, y, z)));
        }
    }
    private void Update()
    {

        //if (Input.GetKey(KeyCode.Alpha1))
        //{
        //    SetStrategyIsland(new IslandMoveUpDn());
        //}
        //if (Input.GetKey(KeyCode.Alpha2))
        //{
        //    SetStrategyIsland(new ShakeInvisIsland());
        //}
        //if (Input.GetKey(KeyCode.Alpha3))
        //{
        //    SetStrategyIsland(new IslandMoveLR());
        //}
    }
}
