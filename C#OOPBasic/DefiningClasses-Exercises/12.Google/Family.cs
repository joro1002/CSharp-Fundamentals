using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32.SafeHandles;

public class Family
{
    private string parentName;
    private string parentBirthday;

    public Family(string parentName, string parentBirthday)
    {
        this.parentName = parentName;
        this.parentBirthday = parentBirthday;
    }

    public override string ToString()
    {
        return $"{this.parentName} {this.parentBirthday}";
    }
}

