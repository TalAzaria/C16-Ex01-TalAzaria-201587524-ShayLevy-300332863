using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace C16_Ex01_Tal_201587524_Shay_300332863
{
    abstract public class Ship //TODO: check if the access modifier is right (and in the inharit classes)
    {
        abstract public void Movement();
        abstract public Vector2 Position { get; set; }

    }
}