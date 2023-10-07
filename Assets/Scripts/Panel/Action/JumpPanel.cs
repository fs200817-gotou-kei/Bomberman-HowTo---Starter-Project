using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPanel : PanelBase
{
    public override void Execute(ChrCtrl chrCtrl)
    {
        int power = 2;
        chrCtrl.Jump(2);
    }
}
