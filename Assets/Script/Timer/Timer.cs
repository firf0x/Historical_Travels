using System;
public class Timer
{
    private float _time = 0f;
    private float _lastTime;

    // Установка времени
    public Timer(float MaxTime)
    {
        _time = MaxTime;
        _lastTime = _time;
    }
    
    public void Recalculation(float deltaTime)
    {
        _time -= deltaTime;
        if(_time <= 0)
            _time = _lastTime;
    }
    public float GetTime()
    {
        return _time;
    }
}