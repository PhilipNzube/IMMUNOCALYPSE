public interface IHealth
{
    float CurrentHealth { get; }
    float MaxHealth { get; }
    void AddHealth(float amount);
}
