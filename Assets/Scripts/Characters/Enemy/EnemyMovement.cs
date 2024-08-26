public class EnemyMovement : CharacterMovement
{
    EnemyLife enemyLife;

    protected override void Awake()
    {
        base.Awake();

        enemyLife = GetComponent<EnemyLife>();
    }

    protected override void OnEnable()
    {
        base.OnEnable();

        enemyLife.OnRestored += Enable;
    }

    protected override void OnDisable()
    {
        base.OnDisable();

        enemyLife.OnRestored -= Enable;
    }

    void Enable()
    {
        isEnabled = true;
    }
}