public interface IWeapon
{
    void Shoot();
    void Reload();
    bool CanShoot { get; }
    int CurrentAmmo { get; }
}
