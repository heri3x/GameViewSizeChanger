﻿namespace Syy.GameViewSizeChanger
{
    public interface IGameViewSizeApplyer
    {
        void Apply();
        bool IsCurrentGameViewSize();
    }
}