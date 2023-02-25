﻿namespace Randolf.Calc.Library.Models;

public class Calculation
{
    private readonly double _firstValue;
    private readonly Operator? _operator;
    private readonly double _secondValue;

    public Calculation(double firstValue, double secondValue, Operator? @operator)
    {
        _firstValue = firstValue;
        _secondValue = secondValue;
        _operator = @operator;
    }

    public double Calculate()
    {
        return _operator switch
        {
            Operator.Add => _firstValue + _secondValue,
            Operator.Subtract => _firstValue - _secondValue,
            Operator.Multiply => _firstValue * _secondValue,
            Operator.Divide => _firstValue / _secondValue,
            _ => throw new InvalidDataException("Operator not allowed")
        };
    }
}