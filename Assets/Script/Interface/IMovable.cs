using System;
public interface IMovable {
    event Action<float> moveObject;
    event Action<string> MoveInfo;
    void Moved();
}