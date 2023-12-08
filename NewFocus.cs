using System;
using arayuzler_ornek;
namespace abstract_class
{
    public class NewFocus : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }
    }
}