using System;
using System.Collections.Generic;
using System.Text;

namespace Odev4
{
    class MyDictionary<Barcode,Name>
    {
        Barcode[] barcode;
        Name[] name;
        public MyDictionary()
        {
            barcode = new Barcode[0];
            name = new Name[0];
        }

        public int Length { get; internal set; }

        public void Add(Barcode item1, Name item2)
        {
            Barcode[] tempBarcode = barcode;
            Name[] tempName = name;
            barcode = new Barcode[barcode.Length + 1];
            name = new Name[name.Length + 1];

            for (int i = 0; i < tempBarcode.Length; i++)
            {
                barcode[i] = tempBarcode[i];
            }
            

            for (int i = 0; i < tempName.Length; i++)
            {
                name[i] = tempName[i];
            }
            barcode[barcode.Length - 1] = item1;
            name[name.Length - 1] = item2;

            


    }
    }
}
