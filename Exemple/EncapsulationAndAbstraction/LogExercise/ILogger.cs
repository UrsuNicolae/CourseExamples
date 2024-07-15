﻿namespace Exemple.EncapsulationAndAbstraction.Log
{
    public interface ILogger
    {
        void LogInformation(string message);

        void LogError(string message);

        void LogWarning(string message);
    }
}
