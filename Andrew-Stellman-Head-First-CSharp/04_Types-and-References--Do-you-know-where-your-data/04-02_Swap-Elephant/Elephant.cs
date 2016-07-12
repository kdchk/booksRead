using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_02_Swap_Elephant
{
    class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoAmI()
        {
            MessageBox.Show($"My ears are {EarSize} tall", $"{Name} says...");
        }

        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show($"{whoSaidIt.Name} says: {message}");
        }

        public void SpeakTo(Elephant whoTotalkTo, string message)
        {
            whoTotalkTo.TellMe(message, this);
        }
    }
}
