using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVisitor
{
    void Visit(BikeShield aBikeShield);
    void Visit(BikeEngine aBikeEngine);
    void Visit(BikeWeapon aBikeWeapon);
}
