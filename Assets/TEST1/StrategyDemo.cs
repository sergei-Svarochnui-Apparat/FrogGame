using UnityEngine;

public class StrategyDemo : MonoBehaviour
{
    public Unit Player;
    public Unit Enemy;


    private void Start()
    {
        Player.SetAttackStrategy(new SwordAttack());

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Player.SetAttackStrategy(new SwordAttack());
            Player.PerformAttack(Enemy);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Player.SetAttackStrategy(new BowAttack());
            Player.PerformAttack(Enemy);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Player.SetAttackStrategy(new MagickAttack());
            Player.PerformAttack(Enemy);
        }
    }
}
