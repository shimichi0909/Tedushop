using System;

namespace TeduShop.Model.Abtract
{
    internal class maxlengthAttribute : Attribute
    {
        private int v;

        public maxlengthAttribute(int v)
        {
            this.v = v;
        }
    }
}