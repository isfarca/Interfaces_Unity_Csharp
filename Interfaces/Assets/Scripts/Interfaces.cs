/// <summary>
/// This is a basic interface with a single required method.
/// </summary>
public interface IKillable
{
    /// <summary>
    /// Kill logic.
    /// </summary>
    void Kill();
}
    
/// <summary>
/// This is a generic interface where T is a placeholder for a data type that will be provided by the  implementing
/// class.
/// </summary>
/// <typeparam name="T">Any data type.</typeparam>
public interface IDamageable<in T>
{
    /// <summary>
    /// Damage logic.
    /// </summary>
    /// <param name="damageTaken">Any data type.</param>
    void Damage(T damageTaken);
}