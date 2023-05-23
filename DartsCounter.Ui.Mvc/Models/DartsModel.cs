using System.Runtime.InteropServices;

namespace DartsCounter.Ui.Mvc.Models
{
    public class DartsModel
    {
        // Beginwaarde van een leg = 501 
        public int StartingValue { get; set; } = 501;

        // Gegooide score van de speler 
        public int Score { get; set; }

        // Resultaat van de score
        // public int Result { get; set; }
    }
}

