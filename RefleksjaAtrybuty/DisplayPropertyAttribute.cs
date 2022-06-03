using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefleksjaAtrybuty
{
    //klasa z atrybutami przechowuje metadane o konkretnej wartości w jakiej chcemy sformatować nazwe danej włąściwości dowolnego obiektu
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    class DisplayPropertyAttribute : Attribute // musi dziedziczyć po Attribute
    {
        public string DisplayName { get; set; }// stworzyliścmy atrybut którego będziemy mogli używać w innych klasach

        public DisplayPropertyAttribute(string displayName)
        {
            DisplayName = displayName;
        }

        //możemy ograniczyć używanie atrybutu np tylko do właściwości nadając atrybutatrybutowi :>

        //w atrybucie atrybutu możemy nadać flagę która zabrania lub pozwala na wielokrotne użycie

        //atrybuty nakładamy na właściwości klas ale można też na same plasy (patrz klasa person)
    }
}
