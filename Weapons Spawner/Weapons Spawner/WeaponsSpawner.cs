using GTA;
using System;
using System.Windows.Forms;

public class WeaponsSpawner : Script
{
    public WeaponsSpawner()
    {
        Tick += OnTick();
        KeyDown += OnKeyDown();
        KeyUp += OnKeyUp();

        Interval = 10;
    }

    void OnTick(object sender, EventArgs e)
    {

    }

    void OnKeyDown(object sender, KeyEventArgs e)
    {

    }

    void OnKeyUp(object sender, KeyEventArgs e)
    {

    }
}