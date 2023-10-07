using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanel : PanelBase
{
    public override void Execute(ChrCtrl chrCtrl)
    {
        int power = 1;
        chrCtrl.Move(power);
    }
}
