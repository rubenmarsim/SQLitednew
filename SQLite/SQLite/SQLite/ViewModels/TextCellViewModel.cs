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
                    Name = "Flash",
                    Location = "Supervelocidad",
                    Details = "La historia se basa en el superhéroe de DC Comics, Flash, específicamente en Barry Allen, el segundo individuo en tomar dicha identidad. Se trata además de un spin-off de Arrow, serie de televisión basada en Flecha Verde, por lo cual comparten el mismo universo de ficción",
                    Image ="https://www.technobuffalo.com/wp-content/uploads/2016/06/The-Flash-200x200.jpg"
                },
               new Monkey
                {
                    Name = "Superman",
                    Location = "OP",
                    Details = "Superman (cuyo nombre kryptoniano es Kal-El y su nombre terrestre es Clark Kent) es un personaje ficticio, un superhéroe de los cómics que aparece en las publicaciones de DC Comics",
                    Image ="https://screenanarchy.com/assets_c/2017/05/superman-the-movie-1978-photo-01-630-thumb-860xauto-39193-thumb-200x200-66859.jpg"
                },
               new Monkey
                {
                    Name = "Batman",
                    Location = "Es rico",
                    Details = "Batman (conocido inicialmente como The Bat-Man) es un personaje creado por los estadounidenses Bob Kane y Bill Finger,4​ y propiedad de DC Comics",
                    Image = "https://www.technobuffalo.com/wp-content/uploads/2015/04/batman-suit-002-200x200.jpg"
                },
                new Monkey
                {
                    Name = "Wonder Woman",
                    Location = "Super vuelo, súper fuerza, inmortalidad, factor de curación, super velocidad, reflejos, resistencia, brazaletes que repelen cualquier tipo de arma, habilidad de lucha altamente desarrollada y posee un lazo mágico",
                    Details ="La Mujer Maravilla (en inglés: Wonder Woman) es una superheroína ficticia creada por William Moulton Marston para la editorial DC Comics",
                    Image ="https://todatecnologia.com/wp-content/uploads/2016/07/Wonder-Woman-200x200.jpg"
                },
                new Monkey
                {
                    Name = "Linterna Verde",
                    Location = "Uso de la luz para crear objetos",
                    Details ="Linterna Verde (en inglés: Green Lantern) es el alias de varios superhéroes de la ficción del Universo DC",
                    Image ="https://images-eu.ssl-images-amazon.com/images/I/412X7C8-G+L._AC_US200_.jpg"
                },
                new Monkey
                {
                    Name = "Aquaman",
                    Location = "Dominio del agua",
                    Details ="Aquaman (cuyo verdadero nombre es Arthur Curry) es un superhéroe que aparece en los cómics estadounidenses publicados por DC Comics",
                    Image ="https://todatecnologia.com/wp-content/uploads/2017/03/Jason-Momoa-como-Aquaman-200x200.jpg"
                },
            };
        }
    }
}
