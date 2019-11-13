using UnityEngine;


public delegate void OutOfBoundHandler();

public class ProjectileController : MonoBehaviour
{
    #region Field Declarations

    public Vector2 projectileDirection;
    public float projectileSpeed;
    public bool isPlayers;


    #endregion

    
    public event OutOfBoundHandler projectileOutOfBound;

    #region Movement

    // Update is called once per frame
    void Update()
    {
        MoveProjectile();
    }

    private void MoveProjectile()
    {
        transform.Translate(projectileDirection * Time.deltaTime * projectileSpeed, Space.World);

        if (ScreenBounds.OutOfBounds(transform.position))
        {
            if (projectileOutOfBound != null)
            {
                projectileOutOfBound();
            }

            
            Destroy(gameObject);
        }
    }

    #endregion
}
