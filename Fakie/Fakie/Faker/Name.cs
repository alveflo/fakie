using System;

namespace Fakie.Faker
{
    public static class Name
    {
        public static string SurName => GetSurName();
        public static string LastName => GetLastName();
        public static string FullName => $"{SurName} {LastName}";

        private static string GetSurName()
        {
            var length = Names.Length;
            var random = new Random();
            var rand = random.Next(0, length - 1);
            return Names[rand].Split(' ')[0];
        }

        private static string GetLastName()
        {
            var length = Names.Length;
            var random = new Random();
            var rand = random.Next(0, length - 1);
            return Names[rand].Split(' ')[1];
        }

        public static string[] Names = new string[] {
          "Aayla Secura",
          "Admiral Ackbar",
          "Admiral Thrawn",
          "Ahsoka Tano",
          "Anakin Solo",
          "Asajj Ventress",
          "Aurra Sing",
          "Senator Bail Organa",
          "Barriss Offee",
          "Bastila Shan",
          "Ben Skywalker",
          "Bib Fortuna",
          "Biggs Darklighter",
          "Boba Fett",
          "Cad Bane",
          "Cade Skywalker",
          "Callista Ming",
          "Captain Rex",
          "Carnor Jax",
          "Clone Commander Cody",
          "Count Dooku",
          "Darth Bane",
          "Darth Krayt",
          "Darth Maul",
          "Darth Nihilus",
          "Darth Vader",
          "Dash Rendar",
          "Emperor Palpatine",
          "Exar Kun",
          "Galen Marek",
          "General Crix Madine",
          "General Dodonna",
          "General Grievous",
          "General Veers",
          "Gilad Pellaeon",
          "Grand Moff Tarkin",
          "Han Solo",
          "Jabba The Hutt",
          "Jacen Solo",
          "Jaina Solo",
          "Jango Fett",
          "Joruus C'Baoth",
          "Ki-Adi-Mundi",
          "Kir Kanos",
          "Kit Fisto",
          "Kyle Katarn",
          "Kyp Durron",
          "Lando Calrissian",
          "Luke Skywalker",
          "Luminara Unduli",
          "Mace Windu",
          "Mara Jade",
          "Mission Vao",
          "Natasi Daala",
          "Nom Anor",
          "Obi-Wan Kenobi",
          "Padmé Amidala",
          "Plo Koon",
          "Pre Vizsla",
          "Prince Xizor",
          "Princess Leia",
          "Qui-Gon Jinn",
          "Quinlan Vos",
          "Rahm Kota",
          "Satele Shan",
          "Savage Opress",
          "Shaak Ti",
          "Shmi Skywalker",
          "Talon Karrde",
          "Ulic Qel-Droma",
          "Visas Marr",
          "Wedge Antilles",
          "Zam Wesell",
          "Zayne Carrick",
        };
    }
}
