using System;
using System.Collections.Generic;



public interface IRemoteControl
{
    void TurnOn();
    void TurnOff();
    void SetChannel(int channel);
}

public class Television : IRemoteControl
{
    private int channel;
    public void TurnOn() => Console.WriteLine("The TV is on");
    public void TurnOff() => Console.WriteLine("The TV is off");
    public void SetChannel(int channel)
    {
        this.channel = channel;
        Console.WriteLine($"The channel is on: {channel}");
    }
}

// Клас Радіо
public class Radio : IRemoteControl
{
    private int frequency;
    public void TurnOn() => Console.WriteLine("The radio is on");
    public void TurnOff() => Console.WriteLine("The radio is off");
    public void SetChannel(int channel)
    {
        this.frequency = channel;
        Console.WriteLine($"Radio frequency: {channel} FM");
    }
}


class Program
{
    static void Main()
    {
        IRemoteControl tv = new Television();
        tv.TurnOn();
        tv.SetChannel(12);
        tv.TurnOff();

        IRemoteControl radio = new Radio();
        radio.TurnOn();
        radio.SetChannel(120);
        radio.TurnOff();
    }
}
