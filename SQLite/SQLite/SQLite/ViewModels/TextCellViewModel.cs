using SQLite.Models;
using SQLite.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SQLite.ViewModels
{
    public class TextCellViewModel : ViewModelBase
    {
        //SQLiteConnection db = new SQLiteConnection(dbPath);
        public ObservableCollection<Monkey> Monkeys { get; set; }

        public TextCellViewModel()
        {
            Monkeys = new ObservableCollection<Monkey>
            {
                new Monkey
                {
                    Name = "Light Yagami",
                    Location = "Kira",
                    Details = "Es l'assasi i el protagonista principal, també qui rep la Death Note.",
                    Image ="drawable/light.jpeg"
                },
               new Monkey
                {
                    Name = "Ryuk",
                    Location = "Shinigami",
                    Details = "Shinigami que li pertany la death note que té en Light.",
                    Image ="drawable/Ryuk.PNG"
                },
               new Monkey
                {
                    Name = "L",
                    Location = "Lawliet",
                    Details = "Detectiu pricipal que intenta enxampar a Light.",
                    Image = "drawable/L.jpg"
                },
                new Monkey
                {
                    Name = "Misa Amane",
                    Location = "Shinigami",
                    Details ="Ajudant amb ulls de shinigami que ajuda en Light.",
                    Image ="drawable/Amane.jpg"
                },
                new Monkey
                {
                    Name = "Rem",
                    Location = "Shinigami",
                    Details ="Shinigami que pertany a la Death note que te la Misa Amane.",
                    Image ="drawable/Rem.PNG"
                },
                new Monkey
                {
                    Name = "Near",
                    Location = "Investigador",
                    Details ="Segon detectiu i qui descobreix en Light.",
                    Image ="drawable/Near.PNG"
                },
            };
        }
    }
}
