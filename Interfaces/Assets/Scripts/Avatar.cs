using UnityEngine;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{
    /// <inheritdoc cref="IKillable.Kill"/>
    public void Kill()
    {
        // Do something fun.
    }

    /// <inheritdoc cref="IDamageable{T}.Damage"/>
    public void Damage(float damageTaken)
    {
        // Do something fun.
    }
}