

using Grundlagen_in_Csharp;

namespace Abstraktklasse
{

    public abstract class AbstraktKlasse : IKatzenInterface
    {
        public string miau()
        {
            return "Miau!"; 
        }
    }


}