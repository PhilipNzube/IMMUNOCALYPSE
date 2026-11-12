public interface ICountdownTimer
{
    float RemainingTime { get; }
    bool IsRunning { get; }
    void StartTimer(float duration);
    void StopTimer();
}
